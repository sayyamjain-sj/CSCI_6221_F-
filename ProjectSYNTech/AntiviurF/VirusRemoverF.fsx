open System
open System.IO
open System.Security.Cryptography

// Function to compute SHA256 hash of a file
let sha256Hash (filename:string) =
    try
       use fs = new FileStream(filename, FileMode.Open, FileAccess.Read)
       use sha256 = SHA256.Create()
       sha256.ComputeHash(fs) |> BitConverter.ToString |> fun s -> s.Replace("-", "")
    with
    | :? System.UnauthorizedAccessException as ex ->
        printfn "Access to the file is denied: %s" ex.Message
        ""
    | :? System.IO.IOException as ex ->
        printfn "An I/O error occurred: %s" ex.Message
        ""
    | :? System.Security.SecurityException as ex ->
        printfn "Security error occurred: %s" ex.Message
        ""
    | ex ->
        printfn "An unexpected error occurred: %s" ex.Message
        ""

// Malware detection using SHA256
let malwareChecker (filepath:string) =
    let hashToCheck = sha256Hash filepath
    use malwareHashes = new StreamReader(@"C:\Users\naiti\OneDrive\Desktop\GW Studies\ProjectSYN\VirusHashSHA256Database.txt")
    let rec loop () =
        match malwareHashes.ReadLine() with
        | null -> 0
        | line ->
            if line.Trim() = hashToCheck then
                1
            else
                loop ()
    loop ()

//Deep Scanning on folders
let mutable temp = 0
let rec folderScanner (path:string) =
    try
        let dirList = Directory.GetFileSystemEntries(path)
        for entry in dirList do
            if File.Exists entry then  // Ensure it's a file
                if malwareChecker entry <> 0 then
                    printfn "Virus found !  Filepath :: %s" entry
                    temp <- 1
                    File.Delete(entry)
            elif Directory.Exists entry then
                folderScanner entry
    with
    | _->()
folderScanner @"C:\Users\naiti\OneDrive\Desktop\GW Studies\Fall 2023\ScanFolder"
if temp = 1 then printfn "Virus files removed successfully."
else printfn "System is clean !"
