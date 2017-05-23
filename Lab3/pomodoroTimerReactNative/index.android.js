/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 * @flow
 */

import React, { Component } from 'react';
import { AppRegistry, StyleSheet, Text, View } from 'react-native';
import Main from './app/components/main.js'

export default class pomodoroTimerReactNative extends Component {
  render() {
    return (
      <View>
        <Main />
      </View>
    );
  }
}

AppRegistry.registerComponent('pomodoroTimerReactNative', () => pomodoroTimerReactNative);
