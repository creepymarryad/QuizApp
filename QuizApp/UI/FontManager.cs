using System.Drawing.Text;
using System.Reflection;

namespace UI
{
    public class FontManager
    {
        private static PrivateFontCollection _pfc = new PrivateFontCollection();

        public static void LoadFontFromResource(string fileName)
        {
            if (_pfc.Families.Length > 0) return;

            var assembly = Assembly.GetExecutingAssembly();

            string resourceName = assembly.GetManifestResourceNames()
                                          .FirstOrDefault(r => r.EndsWith(fileName));

            if (resourceName == null)
            {
                throw new Exception($"Not found: {fileName}");
            }
            string newFileName = $"{Guid.NewGuid()}_{fileName}";
            string tempFilePath = Path.Combine(Path.GetTempPath(), newFileName);

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (FileStream fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                {
                    stream.CopyTo(fileStream);
                }
            }

            _pfc.AddFontFile(tempFilePath);
        }

        public static Font GetFont(float size, int familyIndex = 0, FontStyle style = FontStyle.Regular)
        {
            if (_pfc.Families.Length == 0)
                return new Font("Segoe UI", size, style);

            return new Font(_pfc.Families[familyIndex], size, style);
        }
    }
}