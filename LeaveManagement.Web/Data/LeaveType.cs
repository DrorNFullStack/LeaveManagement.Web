namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseLeaveEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
