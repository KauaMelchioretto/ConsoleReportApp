using System.Diagnostics;
using System.Text;

namespace ConsoleReportApp.Utils
{
    public class SystemInfoCollector
    {
        public static string GetFormattedInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome da máquina: {Environment.MachineName}");
            sb.AppendLine($"Sistema operacional: {Environment.OSVersion}");
            sb.AppendLine($"Processadores lógicos: {Environment.ProcessorCount}");
            sb.AppendLine($"Memória total (MB): {GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024)}");
            sb.AppendLine($"Tempo de atividade: {TimeSpan.FromMilliseconds(Environment.TickCount64)}");
            sb.AppendLine($"Número de processos: {Process.GetProcesses().Length}");

            var drive = DriveInfo.GetDrives()[0];

            if (drive.IsReady)
            {
                sb.AppendLine($"Disco: {drive.Name}");
                sb.AppendLine($" Total (GB): {drive.TotalSize / (1024 * 1024 * 1024)}");
                sb.AppendLine($" Livre (GB): {drive.TotalFreeSpace / (1024 * 1024 * 1024)}");
            }

            return sb.ToString();
        }

        public static string GetCsvInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nome da máquina,{Environment.MachineName}");
            sb.AppendLine($"Sistema operacional,{Environment.OSVersion}");
            sb.AppendLine($"Processadores lógicos,{Environment.ProcessorCount}");
            sb.AppendLine($"Memória total MB,{GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024)}");
            sb.AppendLine($"Tempo de atividade,{TimeSpan.FromMilliseconds(Environment.TickCount64)}");
            sb.AppendLine($"Número de processos,{Process.GetProcesses().Length}");

            var drive = DriveInfo.GetDrives()[0];
            if (drive.IsReady)
            {
                sb.AppendLine($"Disco {drive.Name} Total GB,{drive.TotalSize / (1024 * 1024 * 1024)}");
                sb.AppendLine($"Disco {drive.Name} Livre GB,{drive.TotalFreeSpace / (1024 * 1024 * 1024)}");
            }

            return sb.ToString();
        }
    }
}
