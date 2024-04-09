open System
open System.IO

let rec TempFile (path:string) =
    try
        let dirList = Directory.GetFileSystemEntries(path)
        for entry in dirList do
            if File.Exists entry then  // CheckforFiles
                printfn " %s" entry
                try
                    File.Delete(entry)
                with
                | _ -> () // Ignore any IOExceptions
            elif Directory.Exists entry then
                TempFile entry
        let dirList2 = Directory.GetDirectories(path)
        for entry in dirList2 do
            if Directory.Exists entry then  // Checking for Directories
                printfn " %s" entry
                try
                    Directory.Delete(entry)
                with
                | _ -> () // Ignore any IOExceptions
            elif Directory.Exists entry then
                TempFile entry
    with
    | _ -> () // Ignore any UnauthorizedAccessExceptions, DirectoryNotFoundExceptions, or PathTooLongExceptions
    

let formatPath (path: string) =
    // Replace backslashes with forward slashes
    let username = Environment.GetEnvironmentVariable("USERNAME")
    printfn "%s" username
    let formattedPath = path.Replace(@"Username", username)
    // Normalize the path to remove any redundant separators or ".." components
    Path.GetFullPath(formattedPath)

let filePath = @"C:\Users\Username\AppData\Local\Temp"
let formattedFilePath = formatPath filePath
printfn "Formatted file path: %s" formattedFilePath
let FilePath1 = @"C:\Windows\Temp"
let FilePath2= @"C:\Windows\Prefetch"
TempFile(formattedFilePath)
TempFile(FilePath1)
TempFile(FilePath2)


