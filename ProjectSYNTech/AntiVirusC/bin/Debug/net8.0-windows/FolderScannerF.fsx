
open System
open System.IO
open System.Security.Cryptography


// Function to compute SHA256 hash of a file
let sha256Hash (filename:string) =
    use fs = new FileStream(filename, FileMode.Open, FileAccess.Read)
    use sha256 = SHA256.Create()
    sha256.ComputeHash(fs) |> BitConverter.ToString |> fun s -> s.Replace("-", "")

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
let mutable temp = 0
let folderScanner () =
    let mutable path = @"C:\Users\naiti\OneDrive\Desktop\GW Studies"
    let inputString() : string = Console.ReadLine()
    try
        printfn "Input folder path:"
        let userInput = inputString()
        path <- userInput
        let dirList = Directory.GetFiles(path)
        let mutable pathName = " "
        for fileName in dirList do
            if malwareChecker fileName <> 0 then
                printfn "Folder in infected!  Path: %s  ::  File %s" path  fileName
                temp <- 1
        if temp = 1 then
            printfn "Delete these files"
        else
            printfn "Folder is clean"  
    with
    | :? System.IO.FileNotFoundException as ex ->
        printfn "File not found: %s" ex.Message
        
    | :? System.IO.DirectoryNotFoundException as ex ->
        printfn "Directory not found: %s" ex.Message
        
    | :? System.UnauthorizedAccessException as ex ->
        printfn "Access to the file is denied: %s" ex.Message
        
    | :? System.IO.IOException as ex ->
        printfn "An I/O error occurred: %s" ex.Message
        
    | :? System.Security.SecurityException as ex ->
        printfn "Security error occurred: %s" ex.Message
        
    | ex ->
        printfn "An unexpected error occurred: %s" ex.Message
        
let pathName = folderScanner ()
