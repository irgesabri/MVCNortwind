namespace Northwnd.MvcWebUI.Models
{
    public class PageInfo
    {
        public int CurrentCategory { get; internal set; }
        public int CurrrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
    }
}