using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveRequestRepository: IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM request);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequestVM>> GetAllAsync(string employeeid);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task CancelLeaveRequest(int leaveRequestId);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
    }
}
