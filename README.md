# Argsposer
<img src="https://raw.githubusercontent.com/ndm13/Argsposer/master/pipe-inspect.png" alt="logo: l-pipe with magnifying glass" width="200"/>

Args + exposer.  This tool shows you exactly what was sent to it.

I needed to debug arguments and data passed/piped into a program.  This is
the easiest way to do that.  It's just a C# program that dumps its arguments
(with indices) and all data piped into it.  Perfect for checking links with
"Open With...", checking formatting of interprocess data (rename it to
whatever target you like!), and countless other uses.

## Build Notes
The only imports for the actual `cs` file are `System` and `System.Threading`,
so there's no real reason this *has* to be a Windows Desktop project.  Feel
free to export it as a .NET Core application or whatever you feel is
appropriate.

## Example Usage
### Direct Invocation
Great for inspecting the piped output of a program and checking how your
shell passes command line arguments.
```
C:\>echo Here is some data echoed to another process. | argsposer -f --long-flag=value parameter
Argsposer v.1 - The Only Version You Need
─────────────────────────────────────────
Command Line Arguments:
 0: '-f'
 1: '--long-flag=value'
 2: 'parameter'

Piped Data:
Here is some data echoed to another process.

Ctrl-C to exit...
```
### Open With / Drag-And-Drop
Exposes full address of links with an unknown protocol and gives you a quick
way to check paths without unmasking (e.g. .url and .lnk files).
```
Argsposer v.1 - The Only Version You Need
─────────────────────────────────────────
Command Line Arguments:
 0: 'C:\Users\Public\Desktop\Firefox.lnk'

No piped data.

Ctrl-C to exit...
```
