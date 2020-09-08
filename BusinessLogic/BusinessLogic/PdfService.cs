using BusinessLogic.Helpers;
using BusinessLogic.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;

namespace BusinessLogic.BusinessLogic
{
    public class PdfService
    {
        public static void CreateDoc(ReportInfo reportInfo)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(reportInfo.FileName, FileMode.Create));
            document.Open();
            BaseFont baseFont = BaseFont.CreateFont(
                @"C:\Windows\Fonts\arial.ttf",
                BaseFont.IDENTITY_H,
                BaseFont.NOT_EMBEDDED);
            Font font = new Font(baseFont, 8, Font.NORMAL);
            PdfPTable table = new PdfPTable(6);
            PdfPCell headerCell = new PdfPCell(new Phrase(
                "Отчет по заказам с "
                + reportInfo.StartDate.ToShortDateString()
                + " по "
                + reportInfo.EndDate.ToShortDateString(), font))
            {
                Colspan = 6,
                HorizontalAlignment = 1,
                Border = 0
            };
            table.AddCell(headerCell);
            PdfPCell emptyCell = new PdfPCell(new Phrase(" ", font))
            {
                Colspan = 6,
                HorizontalAlignment = 1,
                Border = 0
            };
            table.AddCell(emptyCell);
            SetHeaders(table, font);
            SetData(reportInfo.Roles, table, font);
            document.Add(table);
            document.Close();
        }

        private static void SetHeaders(PdfPTable table, Font font)
        {
            PdfPCell nameCell = new PdfPCell(new Phrase("Роль", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(nameCell);
            PdfPCell countCell = new PdfPCell(new Phrase("Создана", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(countCell);
            PdfPCell statusCell = new PdfPCell(new Phrase("Имя пользователя", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(statusCell);
            PdfPCell creationCell = new PdfPCell(new Phrase("Логин пользователя", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(creationCell);
            PdfPCell completionCell = new PdfPCell(new Phrase("Создан", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(completionCell);
            PdfPCell amountCell = new PdfPCell(new Phrase("Сумма", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(amountCell);
        }

        private static void SetData(List<ReportViewModel> roles, PdfPTable table, Font font)
        {
            foreach (var role in roles)
            {
                table.AddCell(new Phrase(role.RoleName, font));
                table.AddCell(new Phrase(role.RoleCreationDate.ToString(), font));
                table.AddCell(new Phrase(role.UserName, font));
                table.AddCell(new Phrase(role.UserLogin, font));
                table.AddCell(new Phrase(role.UserCreationDate.ToString(), font));
            }
        }
    }
}
