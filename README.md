# The MIF
The MIF is file searching tool based on [FastSearchLibrary](https://github.com/VladPVS/FastSearchLibrary "FastSearchLibrary").
This tool uses very fast multithreading search algorithm that consumes almost all available processor resources.

![Main window](http://vlad-web.ucoz.ru/GitHub/The_MIF.png)

Functional opportunities:
* Search files
* View finding files
* Copying finding files
* Moving finding files
* Deleting finding files

## SEARCHING MODES
Tool allows to execute search using either conventional text pattern or sophisticated regular expression.  

### Conventional pattern mode
Text pattern represents conventional text that can include two special symbols: `?` and `*`:
* `?` means zero or one any symbol.
For example, pattern `a?.txt` matches `ab.txt`, `aa.txt`, `aw.txt`, `a.txt` etc.
* `*` means any amount of any symbols.
For example, if one need to find all .txt files, one can use next pattern: `*.txt`. 

Pattern may not include any special symbols in conventional mode. In this case search results will contain all files, 
that contain pattern in their names.
For example, if one use word `temporary` as pattern, one may get next result:

    C:\Users\temporary.txt
    C:\Users\Contemporary science.pdf
    D:\Temporary_files.zip  

Note that pattern in conventional mode IS NOT case sensitive.

### Regular expression pattern mode
If one need to execute some complicated search, one should use `regular expression` search mode.
One can read about regular expressions on [Wikipedia](https://en.wikipedia.org/wiki/Regular_expression "Regular expression").

Note that pattern in `regular expression` mode IS case sensitive.

## COMMAND LINE ARGUMENTS
As search process consumes a lot of resources, by default one can launch only one instance of program.
But if really necessity to launch several instances exists, one should use `-fl` command line argument.
 
Example: `C:\Program Files\MIF.exe -fl`
  
Instance of program launched with `-fl` argument will have `(Forced Launch)` note in window caption.

## RECOMMENDATIONS
1. Don't use any "heavy" software while you execute search.
2. Don't launch several searches at the same time.
3. Don't copy, move or delete big amount of files because you will not have opportunity to cancel this operation.
4. Use "conventional" search mode for maximal search speed and "regular expression" search mode for maximal search flexibility. 
5. Leave the directories field empty if you want to execute search on all drives. 
