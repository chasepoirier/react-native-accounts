
# react-native-accounts

## Getting started

`$ npm install react-native-accounts --save`

### Mostly automatic installation

`$ react-native link react-native-accounts`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-accounts` and add `RNAccounts.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAccounts.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAccountsPackage;` to the imports at the top of the file
  - Add `new RNAccountsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-accounts'
  	project(':react-native-accounts').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-accounts/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-accounts')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAccounts.sln` in `node_modules/react-native-accounts/windows/RNAccounts.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Accounts.RNAccounts;` to the usings at the top of the file
  - Add `new RNAccountsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAccounts from 'react-native-accounts';

// TODO: What to do with the module?
RNAccounts;
```
  