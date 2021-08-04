using System;

namespace certificacao_csharp_roteiro
{
    class InteropCOM : IAulaItem
    {
        public void Executar()
        {
            /*
                Acredito que este código será funcional apenas em windows com exel instalado.
                Mais o Fato é que o DLR que roda sobre o CLR possibilita o C# que é uma linguagem Tipada ter recurso dinâmicos,
                Isso facilita na interoperabilidade com outros softwares.

                vide o exemplo de uma planilha do excel sendo preenchida dinâmicamente através da tecnologia COM(dos programas do pacote office)
            */
            Type excelType = Type.GetTypeFromProgID("Excel.Application", true);
            dynamic excel = Activator.CreateInstance(excelType);

            excel.Visible = true;
            excel.Workbooks.Add();

            dynamic planilha = excel.ActiveSheet;

            planilha.Cells[1, "A"] = "Alura";
            planilha.Cells[1, "B"] = "Cursos";
            planilha.Cells[2, "A"] = "Certificação";
            planilha.Cells[2, "B"] = "C#";
            planilha.Columns[1].AutoFit();
            planilha.Columns[2].AutoFit();
        }
    }
}