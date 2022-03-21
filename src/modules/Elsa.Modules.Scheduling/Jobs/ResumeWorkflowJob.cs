using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Elsa.Jobs.Abstractions;
using Elsa.Models;
using Elsa.Runtime.Contracts;
using Elsa.Runtime.Models;
using Elsa.Jobs.Contracts;
using Elsa.Jobs.Models;

namespace Elsa.Modules.Scheduling.Jobs;

public class ResumeWorkflowJob : Job
{
    [JsonConstructor]
    public ResumeWorkflowJob()
    {
    }

    public ResumeWorkflowJob(string workflowInstanceId, Bookmark bookmark)
    {
        WorkflowInstanceId = workflowInstanceId;
        Bookmark = bookmark;
    }

    public string WorkflowInstanceId { get; set; } = default!;
    public Bookmark Bookmark { get; set; } = default!;

    protected override async ValueTask ExecuteAsync(JobExecutionContext context)
    {
        var request = new DispatchWorkflowInstanceRequest(WorkflowInstanceId, Bookmark);
        var workflowInvoker = context.GetRequiredService<IWorkflowInvoker>();
        await workflowInvoker.DispatchAsync(request, context.CancellationToken);
    }
}