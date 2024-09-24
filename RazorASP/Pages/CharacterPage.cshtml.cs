using CharactersLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorASP.Pages
{
    public class CharacterPageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Ваши герои"; //title вкладки
        }
        [BindProperty]//связывает свойство и атрибутами
        public Character? Character { get; set; }
        public IActionResult OnPost() //IactionResult
        {
            if(Character is not null && ModelState.IsValid)//проверяет правильно иниц. модель по типу 
            {
                StorageCharacters.charcters.Add(Character);
                return RedirectToPage("/CharacterPage");//перенаправляет к методу OnGet()
            }
            return Page();//возращает текущую страницу без OnGet() (без обновления страницы) 
        }
    }
}
