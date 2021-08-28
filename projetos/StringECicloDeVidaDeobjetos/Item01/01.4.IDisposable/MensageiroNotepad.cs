using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace _01._4.IDisposable_Finalizador
{
    public class MensageiroNotepad : IDisposable
    {
        IntPtr ponteiroNotepad;
        StreamWriter escritor = new StreamWriter("mensagens.txt");

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        public void EnviarMensagem(string mensagem)
        {
            escritor.WriteLine(mensagem);
            escritor.Flush();

            //Obtém os processos do Windows que estão rodando instâncias do Notepad
            Process[] notepads = Process.GetProcessesByName("notepad");
            if (notepads.Length == 0) return;
            if (notepads[0] != null)
            {
                //Se uma janela do Notepad estiver aberta, obtém o ponteiro para essa janela
                ponteiroNotepad = FindWindowEx(notepads[0].MainWindowHandle, new IntPtr(0), "Edit", null);
                //Envia para o Notepad (através do ponteiro) a mensagem digitada
                SendMessage(ponteiroNotepad, 0x000C, 0, mensagem);
            }
        }

        //~MensageiroNotepad()
        //{
        //    //Descarta os recursos não-gerenciados:
        //    CloseHandleEx(Process.GetCurrentProcess().Handle, ponteiroNotepad);
        //    ponteiroNotepad = IntPtr.Zero;
        //}

        const uint PROCESS_DUP_HANDLE = 0x0040;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess,
            [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, IntPtr dwProcessId);

        [Flags]
        enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DuplicateHandle(IntPtr hSourceProcessHandle,
           IntPtr hSourceHandle, IntPtr hTargetProcessHandle, out IntPtr lpTargetHandle,
           uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, DuplicateOptions dwOptions);

        [Flags]
        enum DuplicateOptions : uint
        {
            DUPLICATE_CLOSE_SOURCE = (0x00000001),
            DUPLICATE_SAME_ACCESS = (0x00000002),
        }

        public static bool CloseHandleEx(IntPtr pid, IntPtr handle)
        {
            IntPtr hProcess = OpenProcess(ProcessAccessFlags.DupHandle, false, pid);
            IntPtr dupHandle = IntPtr.Zero;
            bool success = DuplicateHandle(hProcess, handle, IntPtr.Zero, out dupHandle, 0, false, DuplicateOptions.DUPLICATE_CLOSE_SOURCE);
            CloseHandle(hProcess);
            return success;
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: descartar estado gerenciado (objetos gerenciados).
                    escritor.Dispose();
                }

                //Descarta os recursos não-gerenciados:
                CloseHandleEx(Process.GetCurrentProcess().Handle, ponteiroNotepad);
                ponteiroNotepad = IntPtr.Zero;

                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        ~MensageiroNotepad()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(false);
        }

        // Código adicionado para implementar corretamente o padrão descartável.
        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            // TODO: remover marca de comentário da linha a seguir se o finalizador for substituído acima.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

