using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveType);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocations(LeaveAllocationEditVM model);
    }
}
