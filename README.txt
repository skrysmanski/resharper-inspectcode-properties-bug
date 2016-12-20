Steps to reproduce bug:

1. Extract command line tools into "\CommandLineTools"
2. Run "Build.cmd"
3. Run "Inspect.cmd"

Notice the following error:

    The OutputPath property is not set for project 'DotNetLibrary.csproj'. Please check to make sure that you have specified
    a valid combination of Configuration and Platform for this project. Configuration='InspectCode' Platform='x64'. You may
    be seeing this message because you are trying to build a project without a solution file, and have specified a non-default
    Configuration or Platform that doesn't exist for this project. at (724:5)

This error will not happen if the parameter "--properties=Configuration=InspectCode;Platform=x64" is removed from "InspectCode.cmd".
