using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;



namespace EndpointSecurityApp
{
    public class EndpointSecurityApp
    {
        private static Form window;
        private static Panel winFrame;
        
        
        public static void Main(string[] args)
        {
            window = new Form();
            window.Text = "S.Y.N Endpoint Security";
            window.Size = new Size(1200, 800);


            winFrame = new Panel();
            winFrame.Width = 1200;
            winFrame.Height = 800;
            winFrame.BackColor = Color.Black;
            winFrame.Dock = DockStyle.Fill;
            

            window.Controls.Add(winFrame);

            HomeView();

            Application.Run(window);
        }

        public static void HomeView()
        {
            winFrame.Dispose();

            winFrame = new Panel();
            winFrame.Width = 1200;
            winFrame.Height = 800;
            winFrame.BackColor = Color.Black;
            winFrame.Dock = DockStyle.Fill;
            //Button Click test
            
            //Logo
            
            Image LogoImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\Logo.jpg");
            Label Logo = new Label();
            Logo.Image = LogoImg;
            Logo.Width = 300;
            Logo.Height = 300;
            Logo.Location = new Point(450, 0);
            Logo.Parent = winFrame;
            //Home Button
            window.Controls.Add(winFrame);

            Image homeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETEST.png");
            Image hovHomeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETESTHOV.png");

            Label homeButton = new Label();
            homeButton.Image = homeButtonImg;
            homeButton.BackColor = Color.Black;
            homeButton.Width = 300;
            homeButton.Height = 100;
            homeButton.Cursor = Cursors.Hand;
            homeButton.Location = new Point(0, 143);
            homeButton.Parent = winFrame;

            homeButton.MouseEnter += (sender, e) => homeButton.Image = hovHomeButtonImg;
            homeButton.MouseLeave += (sender, e) => homeButton.Image = homeButtonImg;
            homeButton.Click += HomeCall;
            winFrame.Controls.Add(homeButton);
            
            //Deep Scan
            window.Controls.Add(winFrame);

            Image DeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCAN.png");
            Image hovDeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCANHOV.png");

            Label DeepScanButton = new Label();
            DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.BackColor = Color.Black;
            DeepScanButton.Width = 300;
            DeepScanButton.Height = 100;
            DeepScanButton.Cursor = Cursors.Hand;
            DeepScanButton.Location = new Point(0, 238);
            DeepScanButton.Parent = winFrame;

            DeepScanButton.MouseEnter += (sender, e) => DeepScanButton.Image = hovDeepScanButtonImg;
            DeepScanButton.MouseLeave += (sender, e) => DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.Click += DeepScanCall;
            winFrame.Controls.Add(DeepScanButton);
            //Virus Remover
             window.Controls.Add(winFrame);

            Image VirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVER.png");
            Image hovVirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVERHOV.png");

            Label VirusScanButton = new Label();
            VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.BackColor = Color.Black;
            VirusScanButton.Width = 300;
            VirusScanButton.Height = 100;
            VirusScanButton.Cursor = Cursors.Hand;
            VirusScanButton.Location = new Point(0, 338);
            VirusScanButton.Parent = winFrame;

            VirusScanButton.MouseEnter += (sender, e) => VirusScanButton.Image = hovVirusScanButtonImg;
            VirusScanButton.MouseLeave += (sender, e) => VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.Click += VirusScanCall;
            winFrame.Controls.Add(VirusScanButton);
            // Temp File Cleaner
            window.Controls.Add(winFrame);

            Image JunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVER.png");
            Image hovJunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVERHOV.png");

            Label JunkScanButton = new Label();
            JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.BackColor = Color.Black;
            JunkScanButton.Width = 300;
            JunkScanButton.Height = 100;
            JunkScanButton.Cursor = Cursors.Hand;
            JunkScanButton.Location = new Point(0, 438);
            JunkScanButton.Parent = winFrame;

            JunkScanButton.MouseEnter += (sender, e) => JunkScanButton.Image = hovJunkScanButtonImg;
            JunkScanButton.MouseLeave += (sender, e) => JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.Click += JunkScanCall;
            winFrame.Controls.Add(JunkScanButton);
            // Ram Booster
            window.Controls.Add(winFrame);

            Image RAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTER.png");
            Image hovRAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTERHOV.png");

            Label RAMScanButton = new Label();
            RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.BackColor = Color.Black;
            RAMScanButton.Width = 300;
            RAMScanButton.Height = 100;
            RAMScanButton.Cursor = Cursors.Hand;
            RAMScanButton.Location = new Point(0, 538);
            RAMScanButton.Parent = winFrame;

            RAMScanButton.MouseEnter += (sender, e) => RAMScanButton.Image = hovRAMScanButtonImg;
            RAMScanButton.MouseLeave += (sender, e) => RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.Click += RAMScanCall;
            winFrame.Controls.Add(RAMScanButton);

            // Update 

        window.Controls.Add(winFrame);

            Image UpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\Update.png");
            Image hovUpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\UpdateHov.png");

            Label UpdateScanButton = new Label();
            UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.BackColor = Color.Black;
            UpdateScanButton.Width = 200;
            UpdateScanButton.Height = 50;
            UpdateScanButton.Cursor = Cursors.Hand;
            UpdateScanButton.Location = new Point(0,0);
            UpdateScanButton.Parent = winFrame;

            UpdateScanButton.MouseEnter += (sender, e) => UpdateScanButton.Image = hovUpdateScanButtonImg;
            UpdateScanButton.MouseLeave += (sender, e) => UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.Click += UpdateCall;
            winFrame.Controls.Add(UpdateScanButton);
        }

        
        private static void HomeCall(object sender, EventArgs e)
        {
            HomeView();
        }
        private static void DeepScanCall(object sender, EventArgs e)
        {
            DeepScanView();
        }
        private static void VirusScanCall(object sender, EventArgs e)
        {
            VirusScanView();
        }
        private static void JunkScanCall(object sender, EventArgs e)
        {
            JunkScanView();
        }
        private static void RAMScanCall(object sender, EventArgs e)
        {
            RAMScanView();
        }
        private static void UpdateCall(object sender, EventArgs e)
        {
            UpdateView();
        }
        // Calling DeepScan file
        static string CallFSharpScriptDeepScan(string folderPath)
        {
            try
            {
                // Create process info
                ProcessStartInfo psi = new ProcessStartInfo();
                string filepath = @"OneDrive\Desktop\GW Studies\ProjectSYN\AntiviurF";
                psi.Arguments = $"cd filepath";
                psi.FileName = "dotnet"; // Assuming dotnet CLI is available
                psi.Arguments = $"fsi DeepFolderScanF.fsx"; // Arguments to pass to the F# script
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                // Start the process
                Process process = Process.Start(psi);

                // Read the output of the process
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                return output;

            }
            catch (Exception ex)
            {
                return $"Error occurred: {ex.Message}";
            }
            
        }
        // Calling Virus Remover file
        static string CallFSharpScriptVirusScan(string folderPath)
        {
            try
            {
                // Create process info
                ProcessStartInfo psi = new ProcessStartInfo();
                string filepath = @"OneDrive\Desktop\GW Studies\ProjectSYN\AntiviurF";
                psi.Arguments = $"cd filepath";
                psi.FileName = "dotnet"; // Assuming dotnet CLI is available
                psi.Arguments = $"fsi VirusRemoverF.fsx"; // Arguments to pass to the F# script
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                // Start the process
                Process process = Process.Start(psi);

                // Read the output of the process
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                return output;

            }
            catch (Exception ex)
            {
                return $"Error occurred: {ex.Message}";
            }
            
        }
        // Calling Temp File script
        static string CallFSharpScriptJunkScan(string folderPath)
        {
            try
            {
                // Create process info
                ProcessStartInfo psi = new ProcessStartInfo();
                string filepath = @"OneDrive\Desktop\GW Studies\ProjectSYN\AntiviurF";
                psi.Arguments = $"cd filepath";
                psi.FileName = "dotnet"; // Assuming dotnet CLI is available
                psi.Arguments = $"fsi TempFileF.fsx"; // Arguments to pass to the F# script
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                // Start the process
                Process process = Process.Start(psi);

                // Read the output of the process
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                return output;

            }
            catch (Exception ex)
            {
                return $"Error occurred: {ex.Message}";
            }
            
        }
        // Calling RAM Boost
        static string CallFSharpScriptRAMScan(string folderPath)
        {
            try
            {
                // Create process info
                ProcessStartInfo psi = new ProcessStartInfo();
                string filepath = @"OneDrive\Desktop\GW Studies\ProjectSYN\AntiviurF";
                psi.Arguments = $"cd filepath";
                psi.FileName = "dotnet"; // Assuming dotnet CLI is available
                psi.Arguments = $"fsi RAMboostF.fsx"; // Arguments to pass to the F# script
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                // Start the process
                Process process = Process.Start(psi);

                // Read the output of the process
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                return output;

            }
            catch (Exception ex)
            {
                return $"Error occurred: {ex.Message}";
            }
            
        }
        // Calling RAM Boost
        static string CallFSharpScriptUpdateScan(string folderPath)
        {
            try
            {
                // Create process info
                ProcessStartInfo psi = new ProcessStartInfo();
                string filepath = @"OneDrive\Desktop\GW Studies\ProjectSYN\AntiviurF";
                psi.Arguments = $"cd filepath";
                psi.FileName = "dotnet"; // Assuming dotnet CLI is available
                psi.Arguments = $"fsi DatabaseUpdateF.fsx"; // Arguments to pass to the F# script
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                // Start the process
                Process process = Process.Start(psi);

                // Read the output of the process
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                return output;

            }
            catch (Exception ex)
            {
                return $"Error occurred: {ex.Message}";
            }
            
        }
        // DeepScanView Window
        
        public static void DeepScanView()
        {
            winFrame.Dispose();

            winFrame = new Panel();
            winFrame.Width = 1200;
            winFrame.Height = 800;
            winFrame.BackColor = Color.Black;
            winFrame.Dock = DockStyle.Fill;
            //Button Click test
            Label displayBox = new Label();
            displayBox.Width = 600;
            displayBox.Height = 400;
            displayBox.Location = new Point(300, 200); // Adjust position as needed
            displayBox.BackColor = Color.LightSteelBlue; // Adjust colors as needed
            
            winFrame.Controls.Add(displayBox);
            Label StartButton = new Label
            {
                Text = "Start",
                BackColor = Color.Black,
                Cursor = Cursors.Hand,
                Font = new Font("Poppins", 20, FontStyle.Bold),
                ForeColor = Color.LightSkyBlue,
                Location = new Point(300, 150),
                Height = 50
            };

            
            StartButton.Click += (sender, e)=>
            {
                // Call the F# script and capture its output
                string folderPath = "";
                string output = CallFSharpScriptDeepScan(folderPath);
                displayBox.Text = output;
            };
            

            winFrame.Controls.Add(StartButton);
            
            //Home Button
            window.Controls.Add(winFrame);

            Image homeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETEST.png");
            Image hovHomeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETESTHOV.png");

            Label homeButton = new Label();
            homeButton.Image = homeButtonImg;
            homeButton.BackColor = Color.Black;
            homeButton.Width = 300;
            homeButton.Height = 100;
            homeButton.Cursor = Cursors.Hand;
            homeButton.Location = new Point(0, 143);
            homeButton.Parent = winFrame;

            homeButton.MouseEnter += (sender, e) => homeButton.Image = hovHomeButtonImg;
            homeButton.MouseLeave += (sender, e) => homeButton.Image = homeButtonImg;
            homeButton.Click += HomeCall;
            winFrame.Controls.Add(homeButton);
            
            //Deep Scan
            window.Controls.Add(winFrame);

            Image DeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCAN.png");
            Image hovDeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCANHOV.png");

            Label DeepScanButton = new Label();
            DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.BackColor = Color.Black;
            DeepScanButton.Width = 300;
            DeepScanButton.Height = 100;
            DeepScanButton.Cursor = Cursors.Hand;
            DeepScanButton.Location = new Point(0, 238);
            DeepScanButton.Parent = winFrame;

            DeepScanButton.MouseEnter += (sender, e) => DeepScanButton.Image = hovDeepScanButtonImg;
            DeepScanButton.MouseLeave += (sender, e) => DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.Click += DeepScanCall;
            winFrame.Controls.Add(DeepScanButton);
            //Virus Remover
             window.Controls.Add(winFrame);

            Image VirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVER.png");
            Image hovVirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVERHOV.png");

            Label VirusScanButton = new Label();
            VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.BackColor = Color.Black;
            VirusScanButton.Width = 300;
            VirusScanButton.Height = 100;
            VirusScanButton.Cursor = Cursors.Hand;
            VirusScanButton.Location = new Point(0, 338);
            VirusScanButton.Parent = winFrame;

            VirusScanButton.MouseEnter += (sender, e) => VirusScanButton.Image = hovVirusScanButtonImg;
            VirusScanButton.MouseLeave += (sender, e) => VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.Click += VirusScanCall;
            winFrame.Controls.Add(VirusScanButton);
            // Temp File Cleaner
            window.Controls.Add(winFrame);

            Image JunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVER.png");
            Image hovJunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVERHOV.png");

            Label JunkScanButton = new Label();
            JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.BackColor = Color.Black;
            JunkScanButton.Width = 300;
            JunkScanButton.Height = 100;
            JunkScanButton.Cursor = Cursors.Hand;
            JunkScanButton.Location = new Point(0, 438);
            JunkScanButton.Parent = winFrame;

            JunkScanButton.MouseEnter += (sender, e) => JunkScanButton.Image = hovJunkScanButtonImg;
            JunkScanButton.MouseLeave += (sender, e) => JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.Click += JunkScanCall;
            winFrame.Controls.Add(JunkScanButton);
            // Ram Booster
            window.Controls.Add(winFrame);

            Image RAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTER.png");
            Image hovRAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTERHOV.png");

            Label RAMScanButton = new Label();
            RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.BackColor = Color.Black;
            RAMScanButton.Width = 300;
            RAMScanButton.Height = 100;
            RAMScanButton.Cursor = Cursors.Hand;
            RAMScanButton.Location = new Point(0, 538);
            RAMScanButton.Parent = winFrame;

            RAMScanButton.MouseEnter += (sender, e) => RAMScanButton.Image = hovRAMScanButtonImg;
            RAMScanButton.MouseLeave += (sender, e) => RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.Click += RAMScanCall;
            winFrame.Controls.Add(RAMScanButton);
            // Update 

        window.Controls.Add(winFrame);

            Image UpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\Update.png");
            Image hovUpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\UpdateHov.png");

            Label UpdateScanButton = new Label();
            UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.BackColor = Color.Black;
            UpdateScanButton.Width = 200;
            UpdateScanButton.Height = 50;
            UpdateScanButton.Cursor = Cursors.Hand;
            UpdateScanButton.Location = new Point(0,0);
            UpdateScanButton.Parent = winFrame;

            UpdateScanButton.MouseEnter += (sender, e) => UpdateScanButton.Image = hovUpdateScanButtonImg;
            UpdateScanButton.MouseLeave += (sender, e) => UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.Click += UpdateCall;
            winFrame.Controls.Add(UpdateScanButton);

        }

      
        
        public static void VirusScanView()
        {
            winFrame.Dispose();

            winFrame = new Panel();
            winFrame.Width = 1200;
            winFrame.Height = 800;
            winFrame.BackColor = Color.Black;
            winFrame.Dock = DockStyle.Fill;
            //Button Click test
            Label displayBox = new Label();
            displayBox.Width = 600;
            displayBox.Height = 400;
            displayBox.Location = new Point(300, 200); // Adjust position as needed
            displayBox.BackColor = Color.LightSteelBlue; // Adjust colors as needed
            
            winFrame.Controls.Add(displayBox);
            Label StartButton = new Label
            {
                Text = "Start",
                BackColor = Color.Black,
                Cursor = Cursors.Hand,
                Font = new Font("Poppins", 20, FontStyle.Bold),
                ForeColor = Color.LightSkyBlue,
                Location = new Point(300, 150),
                Height = 50
            };

            
            StartButton.Click += (sender, e)=>
            {
                // Call the F# script and capture its output
                string folderPath = "";
                string output = CallFSharpScriptVirusScan(folderPath);
                displayBox.Text = output;
            };
            

            winFrame.Controls.Add(StartButton);
            
            
            
            //Home Button
            window.Controls.Add(winFrame);

            Image homeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETEST.png");
            Image hovHomeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETESTHOV.png");

            Label homeButton = new Label();
            homeButton.Image = homeButtonImg;
            homeButton.BackColor = Color.Black;
            homeButton.Width = 300;
            homeButton.Height = 100;
            homeButton.Cursor = Cursors.Hand;
            homeButton.Location = new Point(0, 143);
            homeButton.Parent = winFrame;

            homeButton.MouseEnter += (sender, e) => homeButton.Image = hovHomeButtonImg;
            homeButton.MouseLeave += (sender, e) => homeButton.Image = homeButtonImg;
            homeButton.Click += HomeCall;
            winFrame.Controls.Add(homeButton);
            
            
            //Deep Scan
            window.Controls.Add(winFrame);

            Image DeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCAN.png");
            Image hovDeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCANHOV.png");

            Label DeepScanButton = new Label();
            DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.BackColor = Color.Black;
            DeepScanButton.Width = 300;
            DeepScanButton.Height = 100;
            DeepScanButton.Cursor = Cursors.Hand;
            DeepScanButton.Location = new Point(0, 238);
            DeepScanButton.Parent = winFrame;

            DeepScanButton.MouseEnter += (sender, e) => DeepScanButton.Image = hovDeepScanButtonImg;
            DeepScanButton.MouseLeave += (sender, e) => DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.Click += DeepScanCall;
            winFrame.Controls.Add(DeepScanButton);
            //Virus Remover
             window.Controls.Add(winFrame);

            Image VirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVER.png");
            Image hovVirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVERHOV.png");

            Label VirusScanButton = new Label();
            VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.BackColor = Color.Black;
            VirusScanButton.Width = 300;
            VirusScanButton.Height = 100;
            VirusScanButton.Cursor = Cursors.Hand;
            VirusScanButton.Location = new Point(0, 338);
            VirusScanButton.Parent = winFrame;

            VirusScanButton.MouseEnter += (sender, e) => VirusScanButton.Image = hovVirusScanButtonImg;
            VirusScanButton.MouseLeave += (sender, e) => VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.Click += VirusScanCall;
            winFrame.Controls.Add(VirusScanButton);
            // Temp File Cleaner
            window.Controls.Add(winFrame);

            Image JunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVER.png");
            Image hovJunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVERHOV.png");

            Label JunkScanButton = new Label();
            JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.BackColor = Color.Black;
            JunkScanButton.Width = 300;
            JunkScanButton.Height = 100;
            JunkScanButton.Cursor = Cursors.Hand;
            JunkScanButton.Location = new Point(0, 438);
            JunkScanButton.Parent = winFrame;

            JunkScanButton.MouseEnter += (sender, e) => JunkScanButton.Image = hovJunkScanButtonImg;
            JunkScanButton.MouseLeave += (sender, e) => JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.Click += JunkScanCall;
            winFrame.Controls.Add(JunkScanButton);
            // Ram Booster
            window.Controls.Add(winFrame);

            Image RAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTER.png");
            Image hovRAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTERHOV.png");

            Label RAMScanButton = new Label();
            RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.BackColor = Color.Black;
            RAMScanButton.Width = 300;
            RAMScanButton.Height = 100;
            RAMScanButton.Cursor = Cursors.Hand;
            RAMScanButton.Location = new Point(0, 538);
            RAMScanButton.Parent = winFrame;

            RAMScanButton.MouseEnter += (sender, e) => RAMScanButton.Image = hovRAMScanButtonImg;
            RAMScanButton.MouseLeave += (sender, e) => RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.Click += RAMScanCall;
            winFrame.Controls.Add(RAMScanButton);
            // Update 

        window.Controls.Add(winFrame);

            Image UpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\Update.png");
            Image hovUpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\UpdateHov.png");

            Label UpdateScanButton = new Label();
            UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.BackColor = Color.Black;
            UpdateScanButton.Width = 200;
            UpdateScanButton.Height = 50;
            UpdateScanButton.Cursor = Cursors.Hand;
            UpdateScanButton.Location = new Point(0,0);
            UpdateScanButton.Parent = winFrame;

            UpdateScanButton.MouseEnter += (sender, e) => UpdateScanButton.Image = hovUpdateScanButtonImg;
            UpdateScanButton.MouseLeave += (sender, e) => UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.Click += UpdateCall;
            winFrame.Controls.Add(UpdateScanButton);

      
        }
        public static void JunkScanView()
        {
            winFrame.Dispose();

            winFrame = new Panel();
            winFrame.Width = 1200;
            winFrame.Height = 800;
            winFrame.BackColor = Color.Black;
            winFrame.Dock = DockStyle.Fill;
            
            //Button Click test
            Label displayBox = new Label();
            displayBox.Width = 700;
            displayBox.Height = 400;
            displayBox.Location = new Point(300, 200); // Adjust position as needed
            displayBox.BackColor = Color.LightSteelBlue; // Adjust colors as needed
            
            winFrame.Controls.Add(displayBox);
            Label StartButton = new Label
            {
                Text = "Start",
                BackColor = Color.Black,
                Cursor = Cursors.Hand,
                Font = new Font("Poppins", 20, FontStyle.Bold),
                ForeColor = Color.LightSkyBlue,
                Location = new Point(300, 150),
                Height = 50
            };

            
            StartButton.Click += (sender, e)=>
            {
                // Call the F# script and capture its output
                string folderPath = "";
                string output = CallFSharpScriptJunkScan(folderPath);
                displayBox.Text = output;
            };
            

            winFrame.Controls.Add(StartButton);
            
            
            //Home Button
            window.Controls.Add(winFrame);

            Image homeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETEST.png");
            Image hovHomeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETESTHOV.png");

            Label homeButton = new Label();
            homeButton.Image = homeButtonImg;
            homeButton.BackColor = Color.Black;
            homeButton.Width = 300;
            homeButton.Height = 100;
            homeButton.Cursor = Cursors.Hand;
            homeButton.Location = new Point(0, 143);
            homeButton.Parent = winFrame;

            homeButton.MouseEnter += (sender, e) => homeButton.Image = hovHomeButtonImg;
            homeButton.MouseLeave += (sender, e) => homeButton.Image = homeButtonImg;
            homeButton.Click += HomeCall;
            winFrame.Controls.Add(homeButton);
            
            
            //Deep Scan
            window.Controls.Add(winFrame);

            Image DeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCAN.png");
            Image hovDeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCANHOV.png");

            Label DeepScanButton = new Label();
            DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.BackColor = Color.Black;
            DeepScanButton.Width = 300;
            DeepScanButton.Height = 100;
            DeepScanButton.Cursor = Cursors.Hand;
            DeepScanButton.Location = new Point(0, 238);
            DeepScanButton.Parent = winFrame;

            DeepScanButton.MouseEnter += (sender, e) => DeepScanButton.Image = hovDeepScanButtonImg;
            DeepScanButton.MouseLeave += (sender, e) => DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.Click += DeepScanCall;
            winFrame.Controls.Add(DeepScanButton);
            //Virus Remover
             window.Controls.Add(winFrame);

            Image VirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVER.png");
            Image hovVirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVERHOV.png");

            Label VirusScanButton = new Label();
            VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.BackColor = Color.Black;
            VirusScanButton.Width = 300;
            VirusScanButton.Height = 100;
            VirusScanButton.Cursor = Cursors.Hand;
            VirusScanButton.Location = new Point(0, 338);
            VirusScanButton.Parent = winFrame;

            VirusScanButton.MouseEnter += (sender, e) => VirusScanButton.Image = hovVirusScanButtonImg;
            VirusScanButton.MouseLeave += (sender, e) => VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.Click += VirusScanCall;
            winFrame.Controls.Add(VirusScanButton);
            // Temp File Cleaner
            window.Controls.Add(winFrame);

            Image JunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVER.png");
            Image hovJunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVERHOV.png");

            Label JunkScanButton = new Label();
            JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.BackColor = Color.Black;
            JunkScanButton.Width = 300;
            JunkScanButton.Height = 100;
            JunkScanButton.Cursor = Cursors.Hand;
            JunkScanButton.Location = new Point(0, 438);
            JunkScanButton.Parent = winFrame;

            JunkScanButton.MouseEnter += (sender, e) => JunkScanButton.Image = hovJunkScanButtonImg;
            JunkScanButton.MouseLeave += (sender, e) => JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.Click += JunkScanCall;
            winFrame.Controls.Add(JunkScanButton);
            // Ram Booster
            window.Controls.Add(winFrame);

            Image RAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTER.png");
            Image hovRAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTERHOV.png");

            Label RAMScanButton = new Label();
            RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.BackColor = Color.Black;
            RAMScanButton.Width = 300;
            RAMScanButton.Height = 100;
            RAMScanButton.Cursor = Cursors.Hand;
            RAMScanButton.Location = new Point(0, 538);
            RAMScanButton.Parent = winFrame;

            RAMScanButton.MouseEnter += (sender, e) => RAMScanButton.Image = hovRAMScanButtonImg;
            RAMScanButton.MouseLeave += (sender, e) => RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.Click += RAMScanCall;
            winFrame.Controls.Add(RAMScanButton);
            // Update 

        window.Controls.Add(winFrame);

            Image UpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\Update.png");
            Image hovUpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\UpdateHov.png");

            Label UpdateScanButton = new Label();
            UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.BackColor = Color.Black;
            UpdateScanButton.Width = 200;
            UpdateScanButton.Height = 50;
            UpdateScanButton.Cursor = Cursors.Hand;
            UpdateScanButton.Location = new Point(0,0);
            UpdateScanButton.Parent = winFrame;

            UpdateScanButton.MouseEnter += (sender, e) => UpdateScanButton.Image = hovUpdateScanButtonImg;
            UpdateScanButton.MouseLeave += (sender, e) => UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.Click += UpdateCall;
            winFrame.Controls.Add(UpdateScanButton);

      
        }
        public static void RAMScanView()
        {
            winFrame.Dispose();

            winFrame = new Panel();
            winFrame.Width = 1200;
            winFrame.Height = 800;
            winFrame.BackColor = Color.Black;
            winFrame.Dock = DockStyle.Fill;
            //Button Click test
            //Button Click test
            Label displayBox = new Label();
            displayBox.Width = 500;
            displayBox.Height = 400;
            displayBox.Location = new Point(300, 200); // Adjust position as needed
            displayBox.BackColor = Color.LightSteelBlue; // Adjust colors as needed
            
            winFrame.Controls.Add(displayBox);
            Label StartButton = new Label
            {
                Text = "Start",
                BackColor = Color.Black,
                Cursor = Cursors.Hand,
                Font = new Font("Poppins", 20, FontStyle.Bold),
                ForeColor = Color.LightSkyBlue,
                Location = new Point(300, 150),
                Height = 50
            };

            
            StartButton.Click += (sender, e)=>
            {
                // Call the F# script and capture its output
                string folderPath = "";
                string output = CallFSharpScriptRAMScan(folderPath);
                displayBox.Text = output;
            };
            

            winFrame.Controls.Add(StartButton);
            
            
            //Home Button
            window.Controls.Add(winFrame);

            Image homeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETEST.png");
            Image hovHomeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETESTHOV.png");

            Label homeButton = new Label();
            homeButton.Image = homeButtonImg;
            homeButton.BackColor = Color.Black;
            homeButton.Width = 300;
            homeButton.Height = 100;
            homeButton.Cursor = Cursors.Hand;
            homeButton.Location = new Point(0, 143);
            homeButton.Parent = winFrame;

            homeButton.MouseEnter += (sender, e) => homeButton.Image = hovHomeButtonImg;
            homeButton.MouseLeave += (sender, e) => homeButton.Image = homeButtonImg;
            homeButton.Click += HomeCall;
            winFrame.Controls.Add(homeButton);
            
            
            //Deep Scan
            window.Controls.Add(winFrame);

            Image DeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCAN.png");
            Image hovDeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCANHOV.png");

            Label DeepScanButton = new Label();
            DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.BackColor = Color.Black;
            DeepScanButton.Width = 300;
            DeepScanButton.Height = 100;
            DeepScanButton.Cursor = Cursors.Hand;
            DeepScanButton.Location = new Point(0, 238);
            DeepScanButton.Parent = winFrame;

            DeepScanButton.MouseEnter += (sender, e) => DeepScanButton.Image = hovDeepScanButtonImg;
            DeepScanButton.MouseLeave += (sender, e) => DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.Click += DeepScanCall;
            winFrame.Controls.Add(DeepScanButton);
            //Virus Remover
             window.Controls.Add(winFrame);

            Image VirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVER.png");
            Image hovVirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVERHOV.png");

            Label VirusScanButton = new Label();
            VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.BackColor = Color.Black;
            VirusScanButton.Width = 300;
            VirusScanButton.Height = 100;
            VirusScanButton.Cursor = Cursors.Hand;
            VirusScanButton.Location = new Point(0, 338);
            VirusScanButton.Parent = winFrame;

            VirusScanButton.MouseEnter += (sender, e) => VirusScanButton.Image = hovVirusScanButtonImg;
            VirusScanButton.MouseLeave += (sender, e) => VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.Click += VirusScanCall;
            winFrame.Controls.Add(VirusScanButton);
            // Temp File Cleaner
            window.Controls.Add(winFrame);

            Image JunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVER.png");
            Image hovJunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVERHOV.png");

            Label JunkScanButton = new Label();
            JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.BackColor = Color.Black;
            JunkScanButton.Width = 300;
            JunkScanButton.Height = 100;
            JunkScanButton.Cursor = Cursors.Hand;
            JunkScanButton.Location = new Point(0, 438);
            JunkScanButton.Parent = winFrame;

            JunkScanButton.MouseEnter += (sender, e) => JunkScanButton.Image = hovJunkScanButtonImg;
            JunkScanButton.MouseLeave += (sender, e) => JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.Click += JunkScanCall;
            winFrame.Controls.Add(JunkScanButton);
            // Ram Booster
            window.Controls.Add(winFrame);

            Image RAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTER.png");
            Image hovRAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTERHOV.png");

            Label RAMScanButton = new Label();
            RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.BackColor = Color.Black;
            RAMScanButton.Width = 300;
            RAMScanButton.Height = 100;
            RAMScanButton.Cursor = Cursors.Hand;
            RAMScanButton.Location = new Point(0, 538);
            RAMScanButton.Parent = winFrame;

            RAMScanButton.MouseEnter += (sender, e) => RAMScanButton.Image = hovRAMScanButtonImg;
            RAMScanButton.MouseLeave += (sender, e) => RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.Click += RAMScanCall;
            winFrame.Controls.Add(RAMScanButton);
            // Update 

        window.Controls.Add(winFrame);

            Image UpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\Update.png");
            Image hovUpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\UpdateHov.png");

            Label UpdateScanButton = new Label();
            UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.BackColor = Color.Black;
            UpdateScanButton.Width = 200;
            UpdateScanButton.Height = 50;
            UpdateScanButton.Cursor = Cursors.Hand;
            UpdateScanButton.Location = new Point(0,0);
            UpdateScanButton.Parent = winFrame;

            UpdateScanButton.MouseEnter += (sender, e) => UpdateScanButton.Image = hovUpdateScanButtonImg;
            UpdateScanButton.MouseLeave += (sender, e) => UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.Click += UpdateCall;
            winFrame.Controls.Add(UpdateScanButton);

      
        }
        public static void UpdateView()
        {
            winFrame.Dispose();

            winFrame = new Panel();
            winFrame.Width = 1200;
            winFrame.Height = 800;
            winFrame.BackColor = Color.Black;
            winFrame.Dock = DockStyle.Fill;
            
            //Button Click test
            Label displayBox = new Label();
            displayBox.Width = 500;
            displayBox.Height = 400;
            displayBox.Location = new Point(300, 200); // Adjust position as needed
            displayBox.BackColor = Color.White; // Adjust colors as needed
            //displayBox.ReadOnly = true; // Prevents user from editing
            winFrame.Controls.Add(displayBox);
            Label StartButton = new Label
            {
                Text = "Start",
                BackColor = Color.Black,
                Cursor = Cursors.Hand,
                Font = new Font("Poppins", 20, FontStyle.Bold),
                ForeColor = Color.LightSkyBlue,
                Location = new Point(300, 150),
                Height = 50
            };

            
            StartButton.Click += (sender, e)=>
            {
                // Call the F# script and capture its output
                string folderPath = "";
                string output = CallFSharpScriptUpdateScan(folderPath);
                displayBox.Text = output;
            };
            

            winFrame.Controls.Add(StartButton);
            
            //Home Button
            window.Controls.Add(winFrame);

            Image homeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETEST.png");
            Image hovHomeButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\HOMETESTHOV.png");

            Label homeButton = new Label();
            homeButton.Image = homeButtonImg;
            homeButton.BackColor = Color.Black;
            homeButton.Width = 300;
            homeButton.Height = 100;
            homeButton.Cursor = Cursors.Hand;
            homeButton.Location = new Point(0, 143);
            homeButton.Parent = winFrame;

            homeButton.MouseEnter += (sender, e) => homeButton.Image = hovHomeButtonImg;
            homeButton.MouseLeave += (sender, e) => homeButton.Image = homeButtonImg;
            homeButton.Click += HomeCall;
            winFrame.Controls.Add(homeButton);
            
            //Deep Scan
            window.Controls.Add(winFrame);

            Image DeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCAN.png");
            Image hovDeepScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\DEEPSCANHOV.png");

            Label DeepScanButton = new Label();
            DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.BackColor = Color.Black;
            DeepScanButton.Width = 300;
            DeepScanButton.Height = 100;
            DeepScanButton.Cursor = Cursors.Hand;
            DeepScanButton.Location = new Point(0, 238);
            DeepScanButton.Parent = winFrame;

            DeepScanButton.MouseEnter += (sender, e) => DeepScanButton.Image = hovDeepScanButtonImg;
            DeepScanButton.MouseLeave += (sender, e) => DeepScanButton.Image = DeepScanButtonImg;
            DeepScanButton.Click += DeepScanCall;
            winFrame.Controls.Add(DeepScanButton);
            //Virus Remover
             window.Controls.Add(winFrame);

            Image VirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVER.png");
            Image hovVirusScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\VIRUSREMOVERHOV.png");

            Label VirusScanButton = new Label();
            VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.BackColor = Color.Black;
            VirusScanButton.Width = 300;
            VirusScanButton.Height = 100;
            VirusScanButton.Cursor = Cursors.Hand;
            VirusScanButton.Location = new Point(0, 338);
            VirusScanButton.Parent = winFrame;

            VirusScanButton.MouseEnter += (sender, e) => VirusScanButton.Image = hovVirusScanButtonImg;
            VirusScanButton.MouseLeave += (sender, e) => VirusScanButton.Image = VirusScanButtonImg;
            VirusScanButton.Click += VirusScanCall;
            winFrame.Controls.Add(VirusScanButton);
            // Temp File Cleaner
            window.Controls.Add(winFrame);

            Image JunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVER.png");
            Image hovJunkScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\JUNKREMOVERHOV.png");

            Label JunkScanButton = new Label();
            JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.BackColor = Color.Black;
            JunkScanButton.Width = 300;
            JunkScanButton.Height = 100;
            JunkScanButton.Cursor = Cursors.Hand;
            JunkScanButton.Location = new Point(0, 438);
            JunkScanButton.Parent = winFrame;

            JunkScanButton.MouseEnter += (sender, e) => JunkScanButton.Image = hovJunkScanButtonImg;
            JunkScanButton.MouseLeave += (sender, e) => JunkScanButton.Image = JunkScanButtonImg;
            JunkScanButton.Click += JunkScanCall;
            winFrame.Controls.Add(JunkScanButton);
            // Ram Booster
            window.Controls.Add(winFrame);

            Image RAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTER.png");
            Image hovRAMScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\RAMBOOSTERHOV.png");

            Label RAMScanButton = new Label();
            RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.BackColor = Color.Black;
            RAMScanButton.Width = 300;
            RAMScanButton.Height = 100;
            RAMScanButton.Cursor = Cursors.Hand;
            RAMScanButton.Location = new Point(0, 538);
            RAMScanButton.Parent = winFrame;

            RAMScanButton.MouseEnter += (sender, e) => RAMScanButton.Image = hovRAMScanButtonImg;
            RAMScanButton.MouseLeave += (sender, e) => RAMScanButton.Image = RAMScanButtonImg;
            RAMScanButton.Click += RAMScanCall;
            winFrame.Controls.Add(RAMScanButton);
            // Update 

        window.Controls.Add(winFrame);

            Image UpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\Update.png");
            Image hovUpdateScanButtonImg = Image.FromFile(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\Spring 2024\CSCI 6221 ASP\F sharp project\Project Antivirus\Images GUI\UpdateHov.png");

            Label UpdateScanButton = new Label();
            UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.BackColor = Color.Black;
            UpdateScanButton.Width = 200;
            UpdateScanButton.Height = 50;
            UpdateScanButton.Cursor = Cursors.Hand;
            UpdateScanButton.Location = new Point(0,0);
            UpdateScanButton.Parent = winFrame;

            UpdateScanButton.MouseEnter += (sender, e) => UpdateScanButton.Image = hovUpdateScanButtonImg;
            UpdateScanButton.MouseLeave += (sender, e) => UpdateScanButton.Image = UpdateScanButtonImg;
            UpdateScanButton.Click += UpdateCall;
            winFrame.Controls.Add(UpdateScanButton);

      
        }

  
    }
}
