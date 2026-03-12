# BSOD

This lab show how to trigger **Blue Screen of Death (BSOD)** in **Windows VM** using **C#**.  
**Important:** Run only in VM. Never run on real PC.

## ⚠️ Warning
- BSOD will **crash your VM immediately**.  
- **Take snapshot** before run.  
- Only do this for **learning and crash analysis**.

## 1️⃣ Build / Compile

### Option 1: Using Visual Studio
- Open project in **Visual Studio**  
- Set **Build Configuration** → Release  
- Build project

### Option 2: Using .NET CLI (Recommended)
```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
