using System;
using System.Diagnostics;


namespace Acr.UserDialogs {

    public static class Extensions {

        public static AndroidHUD.MaskType ToNative(this MaskType maskType) {
            switch (maskType) {
                case MaskType.Black :
                    return AndroidHUD.MaskType.Black;

                case MaskType.Clear :
                    return AndroidHUD.MaskType.Clear;

                case MaskType.Gradient :
                    Debug.WriteLine("Warning - Gradient mask type is not supported on android");
                    return AndroidHUD.MaskType.Black;

                case MaskType.None :
                    return AndroidHUD.MaskType.None;

                default:
                    throw new ArgumentException("Invalid Mask Type");
            }
        }
    }
}