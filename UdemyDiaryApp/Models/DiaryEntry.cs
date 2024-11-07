using System.ComponentModel.DataAnnotations;

namespace UdemyDiaryApp.Models;

public class DiaryEntry
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Content { get; set; } = string.Empty;
    [Required]
    public DateTime Created { get; set; } = DateTime.Now;
}