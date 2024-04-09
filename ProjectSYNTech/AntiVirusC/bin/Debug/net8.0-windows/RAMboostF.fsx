open System

// Function to boost RAM by killing specified tasks
let RamBooster () =
    let tasklist = ["notepad.exe"; "chrome.exe"; "msedge.exe"; "cmd.exe";"msedgewebview2.exe";"WhatsApp.exe"]
    for i in tasklist do
        try
            System.Diagnostics.Process.Start("taskkill", sprintf "/f /im %s" i) |> ignore
        with
        | ex -> printfn "An error occurred: %s" ex.Message
RamBooster()
