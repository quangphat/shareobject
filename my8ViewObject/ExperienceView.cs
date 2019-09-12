
namespace my8ViewObject
{
    public class ExperienceView
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public LocationView Location { get; set; }
        public int StartMonth { get; set; }
        public int StartYear { get; set; }
        public bool IsPresent { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public JobFunctionView JobFunction { get; set; }
        public string WorkAs { get; set; }
        public string Description { get; set; }
        public string PersonId { get; set; }
    }
}
