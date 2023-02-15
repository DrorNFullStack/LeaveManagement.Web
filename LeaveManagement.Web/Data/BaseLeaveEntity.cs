namespace LeaveManagement.Web.Data
{
    public abstract class BaseLeaveEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
