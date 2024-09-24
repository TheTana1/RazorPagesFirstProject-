using CharactersLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorASP.Pages
{
    public class CharacterPageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "���� �����"; //title �������
        }
        [BindProperty]//��������� �������� � ����������
        public Character? Character { get; set; }
        public IActionResult OnPost() //IactionResult
        {
            if(Character is not null && ModelState.IsValid)//��������� ��������� ����. ������ �� ���� 
            {
                StorageCharacters.charcters.Add(Character);
                return RedirectToPage("/CharacterPage");//�������������� � ������ OnGet()
            }
            return Page();//��������� ������� �������� ��� OnGet() (��� ���������� ��������) 
        }
    }
}
