using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models;

public class Server
{
    public Server()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 2);
        IsOnline = randomNumber == 0 ? false : true;
    }
    public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? City { get; set; } // setting 'required' before 'string' does NOT make it required in the edit form.
    // at least the <DataAnnotationsValidator> in the form does not seem to be triggered
}
