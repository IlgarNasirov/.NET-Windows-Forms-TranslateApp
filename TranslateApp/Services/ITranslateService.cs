using TranslateApp.Entities;

namespace TranslateApp.Services
{
    public interface ITranslateService
    {
        string Translate(TranslateEntity translateEntity);
    }
}
