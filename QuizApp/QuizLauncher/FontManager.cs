using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace QuizLauncher
{
    public class FontManager
    {
        private static PrivateFontCollection _pfc = new PrivateFontCollection();
        public static void LoadFont(string filePath)
        {
            _pfc.AddFontFile(filePath);
        }
        public static Font GetFont(float size, int familyIndex = 0, FontStyle style = FontStyle.Regular)
        {
            if (_pfc.Families.Length == 0)
            {
                return new Font("Segoe UI", size, style);
            }

            if (familyIndex >= _pfc.Families.Length)
            {
                familyIndex = 0;
            }

            return new Font(_pfc.Families[familyIndex], size, style);
        }
    }
}
