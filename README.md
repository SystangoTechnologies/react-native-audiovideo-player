
# react-native-audio-video-player

## Getting started

`$ npm install react-native-audio-video-player --save`

### Mostly automatic installation

`$ react-native link react-native-audio-video-player`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-audio-video-player` and add `RNAudioVideoPlayer.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAudioVideoPlayer.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAudioVideoPlayerPackage;` to the imports at the top of the file
  - Add `new RNAudioVideoPlayerPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-audio-video-player'
  	project(':react-native-audio-video-player').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-audio-video-player/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-audio-video-player')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAudioVideoPlayer.sln` in `node_modules/react-native-audio-video-player/windows/RNAudioVideoPlayer.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Audio.Video.Player.RNAudioVideoPlayer;` to the usings at the top of the file
  - Add `new RNAudioVideoPlayerPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAudioVideoPlayer from 'react-native-audio-video-player';

// TODO: What to do with the module?
RNAudioVideoPlayer;
```
  