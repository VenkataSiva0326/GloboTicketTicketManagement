namespace GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string access_token { get; set; }

        public string user_name  { get; set; }

        public int user_password { get; set; }
    }
}
