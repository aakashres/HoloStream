# Holo Stream Plugin for unity

This plugin is based on [HoloLensCameraStream](https://github.com/VulcanTechnologies/HoloLensCameraStream). This Unity plugin allows you to capture the HoloLens Video Camera frame into the Unity App in real time. This enables Unity developer to manipulate the HoloLens Camera for Computer Vision.


# Usage
- Use this plugin to feed HoloLens real camera stream to do computer vision and machine learning on real time.
- See the preview of what HoloLens camera actually sees
- Obtain a 3D coordinate given an image pixel coordinate from the Hololens Video Camera. You could render a face using computer vision and then render something along side that face.

# Building the plugin
1. Clone the repository
2. Open HoloStream Solution in Visual Studio(22 Comunity Edition). It is HoloStream/HoloStream.sln file.
3. Build the solution In the VS menu, select Build > Build Solution.
4. This will produce one HoloStream.dll file  that can be used in Unity.


# Integrating the plugin into a Unity project
1. Find the DLLs you just build: Look in the output window after you build the plugin solution. You will see one pathto the newly-build DLL. Navigate to them.
2. Paste the plugin DLL into Unity: Copy the plugin DLL from the output directory and paste it into the your Unity app. It must be pasted into the Assets/Plugins/WSA/ARM64 directory in your Unity project or any subdirectory you compile DLL into. 
3. Edit the plugin's settings: In the Unity editor, select the HoloStream.dll plugin file that you pasted in step 2 from Assets folder. In the inspector, check platforms Editor and WSAPlayer. Set the SDK to AnySDK, and set the Scripting Backend to Dot Net.
4. Click Apply.
5. In Build Setting > Project Settings > Players > Other Settings > Configuration, Set API compatibility level to .NET 4.x.
