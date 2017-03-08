
# react-native-zoomsdk

## Getting started

`$ npm install react-native-zoomsdk --save`

### Mostly automatic installation

`$ react-native link react-native-zoomsdk`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-zoomsdk` and add `RNZoomsdk.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNZoomsdk.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNZoomsdkPackage;` to the imports at the top of the file
  - Add `new RNZoomsdkPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-zoomsdk'
  	project(':react-native-zoomsdk').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-zoomsdk/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-zoomsdk')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNZoomsdk.sln` in `node_modules/react-native-zoomsdk/windows/RNZoomsdk.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Com.Reactlibrary.RNZoomsdk;` to the usings at the top of the file
  - Add `new RNZoomsdkPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNZoomsdk from 'react-native-zoomsdk';

// TODO: What to do with the module?
RNZoomsdk;
```
  "# zoomsdk" 
