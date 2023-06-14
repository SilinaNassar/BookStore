namespace BookStore.Models.Grid
{
    public abstract class GridData
    {
        //model binding properties
        public int PageNumber { get; set; } = 1;
        public string SortDirection { get; set; } = "asc";
        public string  SortField { get; set; } = string.Empty;
        public int PageSize { get; set; } = 4;


        //general methods for paging and sorting

        public int GetTotalPage(int count) => (count + PageSize - 1) / PageSize;

        public void SetSortAndDirection(string newSortField,GridData current)
        {
            //set Sort field
            SortField= newSortField;

            //Set sort direction based on comparision of new and current sort field
            //sort field is same as current ,toggle between ascending and descending
            //if its different ,should always be asc
             
            if(current.SortField.EqualsNoCase(newSortField) && current.SortDirection == "asc")
            {
                SortDirection = "desc";
                
            }
            else
            {
                SortDirection = "asc";
            }

            
        }

        public virtual GridData Clone() => (GridData)MemberwiseClone();

        //return Dictionary of route segments for url building
        public virtual Dictionary<string, string> ToDictionary() => new Dictionary<string, string>
        {

            {nameof(PageNumber),PageNumber.ToString()},
            {nameof(PageSize),PageSize.ToString()},
            {nameof(SortField),SortField},
            {nameof(SortDirection),SortDirection},

        };


    }
}
