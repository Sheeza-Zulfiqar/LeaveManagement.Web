using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            //it says it is leggal ot convrrt from type to A to type B
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee,EmployeeListVM>().ReverseMap();
            CreateMap<Employee,EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationEditVM>().ReverseMap();
        }
    }
}
