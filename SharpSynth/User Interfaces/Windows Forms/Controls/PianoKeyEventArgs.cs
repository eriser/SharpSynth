using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpSynth.UserInterface.WindowsForms.Controls
{
    public enum PianoKey
    {
        C,
        CSharp,
        D,
        DSharp,
        E,
        F,
        FSharp,
        G,
        GSharp,
        A,
        ASharp,
        B,
    }

    public class PianoKeyEventArgs : KeyEventArgs
    {
        public PianoKey PianoKeyPressed { get; protected set; }

        public PianoKeyEventArgs(Keys keyData)
            : base(keyData)
        {
            //switch (keyData)
            //{
            //    case Keys.A:
            //        break;
            //    case Keys.Add:
            //        break;
            //    case Keys.Alt:
            //        break;
            //    case Keys.Apps:
            //        break;
            //    case Keys.Attn:
            //        break;
            //    case Keys.B:
            //        break;
            //    case Keys.Back:
            //        break;
            //    case Keys.BrowserBack:
            //        break;
            //    case Keys.BrowserFavorites:
            //        break;
            //    case Keys.BrowserForward:
            //        break;
            //    case Keys.BrowserHome:
            //        break;
            //    case Keys.BrowserRefresh:
            //        break;
            //    case Keys.BrowserSearch:
            //        break;
            //    case Keys.BrowserStop:
            //        break;
            //    case Keys.C:
            //        break;
            //    case Keys.Cancel:
            //        break;
            //    case Keys.Capital:
            //        break;
            //    case Keys.CapsLock:
            //        break;
            //    case Keys.Clear:
            //        break;
            //    case Keys.Control:
            //        break;
            //    case Keys.ControlKey:
            //        break;
            //    case Keys.Crsel:
            //        break;
            //    case Keys.D:
            //        break;
            //    case Keys.D0:
            //        break;
            //    case Keys.D1:
            //        break;
            //    case Keys.D2:
            //        break;
            //    case Keys.D3:
            //        break;
            //    case Keys.D4:
            //        break;
            //    case Keys.D5:
            //        break;
            //    case Keys.D6:
            //        break;
            //    case Keys.D7:
            //        break;
            //    case Keys.D8:
            //        break;
            //    case Keys.D9:
            //        break;
            //    case Keys.Decimal:
            //        break;
            //    case Keys.Delete:
            //        break;
            //    case Keys.Divide:
            //        break;
            //    case Keys.Down:
            //        break;
            //    case Keys.E:
            //        break;
            //    case Keys.End:
            //        break;
            //    case Keys.Enter:
            //        break;
            //    case Keys.EraseEof:
            //        break;
            //    case Keys.Escape:
            //        break;
            //    case Keys.Execute:
            //        break;
            //    case Keys.Exsel:
            //        break;
            //    case Keys.F:
            //        break;
            //    case Keys.F1:
            //        break;
            //    case Keys.F10:
            //        break;
            //    case Keys.F11:
            //        break;
            //    case Keys.F12:
            //        break;
            //    case Keys.F13:
            //        break;
            //    case Keys.F14:
            //        break;
            //    case Keys.F15:
            //        break;
            //    case Keys.F16:
            //        break;
            //    case Keys.F17:
            //        break;
            //    case Keys.F18:
            //        break;
            //    case Keys.F19:
            //        break;
            //    case Keys.F2:
            //        break;
            //    case Keys.F20:
            //        break;
            //    case Keys.F21:
            //        break;
            //    case Keys.F22:
            //        break;
            //    case Keys.F23:
            //        break;
            //    case Keys.F24:
            //        break;
            //    case Keys.F3:
            //        break;
            //    case Keys.F4:
            //        break;
            //    case Keys.F5:
            //        break;
            //    case Keys.F6:
            //        break;
            //    case Keys.F7:
            //        break;
            //    case Keys.F8:
            //        break;
            //    case Keys.F9:
            //        break;
            //    case Keys.FinalMode:
            //        break;
            //    case Keys.G:
            //        break;
            //    case Keys.H:
            //        break;
            //    case Keys.HanguelMode:
            //        break;
            //    case Keys.HangulMode:
            //        break;
            //    case Keys.HanjaMode:
            //        break;
            //    case Keys.Help:
            //        break;
            //    case Keys.Home:
            //        break;
            //    case Keys.I:
            //        break;
            //    case Keys.IMEAccept:
            //        break;
            //    case Keys.IMEAceept:
            //        break;
            //    case Keys.IMEConvert:
            //        break;
            //    case Keys.IMEModeChange:
            //        break;
            //    case Keys.IMENonconvert:
            //        break;
            //    case Keys.Insert:
            //        break;
            //    case Keys.J:
            //        break;
            //    case Keys.JunjaMode:
            //        break;
            //    case Keys.K:
            //        break;
            //    case Keys.KanaMode:
            //        break;
            //    case Keys.KanjiMode:
            //        break;
            //    case Keys.KeyCode:
            //        break;
            //    case Keys.L:
            //        break;
            //    case Keys.LButton:
            //        break;
            //    case Keys.LControlKey:
            //        break;
            //    case Keys.LMenu:
            //        break;
            //    case Keys.LShiftKey:
            //        break;
            //    case Keys.LWin:
            //        break;
            //    case Keys.LaunchApplication1:
            //        break;
            //    case Keys.LaunchApplication2:
            //        break;
            //    case Keys.LaunchMail:
            //        break;
            //    case Keys.Left:
            //        break;
            //    case Keys.LineFeed:
            //        break;
            //    case Keys.M:
            //        break;
            //    case Keys.MButton:
            //        break;
            //    case Keys.MediaNextTrack:
            //        break;
            //    case Keys.MediaPlayPause:
            //        break;
            //    case Keys.MediaPreviousTrack:
            //        break;
            //    case Keys.MediaStop:
            //        break;
            //    case Keys.Menu:
            //        break;
            //    case Keys.Modifiers:
            //        break;
            //    case Keys.Multiply:
            //        break;
            //    case Keys.N:
            //        break;
            //    case Keys.Next:
            //        break;
            //    case Keys.NoName:
            //        break;
            //    case Keys.None:
            //        break;
            //    case Keys.NumLock:
            //        break;
            //    case Keys.NumPad0:
            //        break;
            //    case Keys.NumPad1:
            //        break;
            //    case Keys.NumPad2:
            //        break;
            //    case Keys.NumPad3:
            //        break;
            //    case Keys.NumPad4:
            //        break;
            //    case Keys.NumPad5:
            //        break;
            //    case Keys.NumPad6:
            //        break;
            //    case Keys.NumPad7:
            //        break;
            //    case Keys.NumPad8:
            //        break;
            //    case Keys.NumPad9:
            //        break;
            //    case Keys.O:
            //        break;
            //    case Keys.Oem1:
            //        break;
            //    case Keys.Oem102:
            //        break;
            //    case Keys.Oem2:
            //        break;
            //    case Keys.Oem3:
            //        break;
            //    case Keys.Oem4:
            //        break;
            //    case Keys.Oem5:
            //        break;
            //    case Keys.Oem6:
            //        break;
            //    case Keys.Oem7:
            //        break;
            //    case Keys.Oem8:
            //        break;
            //    case Keys.OemBackslash:
            //        break;
            //    case Keys.OemClear:
            //        break;
            //    case Keys.OemCloseBrackets:
            //        break;
            //    case Keys.OemMinus:
            //        break;
            //    case Keys.OemOpenBrackets:
            //        break;
            //    case Keys.OemPeriod:
            //        break;
            //    case Keys.OemPipe:
            //        break;
            //    case Keys.OemQuestion:
            //        break;
            //    case Keys.OemQuotes:
            //        break;
            //    case Keys.OemSemicolon:
            //        break;
            //    case Keys.Oemcomma:
            //        break;
            //    case Keys.Oemplus:
            //        break;
            //    case Keys.Oemtilde:
            //        break;
            //    case Keys.P:
            //        break;
            //    case Keys.Pa1:
            //        break;
            //    case Keys.Packet:
            //        break;
            //    case Keys.PageDown:
            //        break;
            //    case Keys.PageUp:
            //        break;
            //    case Keys.Pause:
            //        break;
            //    case Keys.Play:
            //        break;
            //    case Keys.Print:
            //        break;
            //    case Keys.PrintScreen:
            //        break;
            //    case Keys.Prior:
            //        break;
            //    case Keys.ProcessKey:
            //        break;
            //    case Keys.Q:
            //        break;
            //    case Keys.R:
            //        break;
            //    case Keys.RButton:
            //        break;
            //    case Keys.RControlKey:
            //        break;
            //    case Keys.RMenu:
            //        break;
            //    case Keys.RShiftKey:
            //        break;
            //    case Keys.RWin:
            //        break;
            //    case Keys.Return:
            //        break;
            //    case Keys.Right:
            //        break;
            //    case Keys.S:
            //        break;
            //    case Keys.Scroll:
            //        break;
            //    case Keys.Select:
            //        break;
            //    case Keys.SelectMedia:
            //        break;
            //    case Keys.Separator:
            //        break;
            //    case Keys.Shift:
            //        break;
            //    case Keys.ShiftKey:
            //        break;
            //    case Keys.Sleep:
            //        break;
            //    case Keys.Snapshot:
            //        break;
            //    case Keys.Space:
            //        break;
            //    case Keys.Subtract:
            //        break;
            //    case Keys.T:
            //        break;
            //    case Keys.Tab:
            //        break;
            //    case Keys.U:
            //        break;
            //    case Keys.Up:
            //        break;
            //    case Keys.V:
            //        break;
            //    case Keys.VolumeDown:
            //        break;
            //    case Keys.VolumeMute:
            //        break;
            //    case Keys.VolumeUp:
            //        break;
            //    case Keys.W:
            //        break;
            //    case Keys.X:
            //        break;
            //    case Keys.XButton1:
            //        break;
            //    case Keys.XButton2:
            //        break;
            //    case Keys.Y:
            //        break;
            //    case Keys.Z:
            //        break;
            //    case Keys.Zoom:
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
