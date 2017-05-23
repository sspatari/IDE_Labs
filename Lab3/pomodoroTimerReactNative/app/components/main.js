import React, { Component } from 'react';
import { AppRegistry, StyleSheet, Text, View } from 'react-native';
import Timer from './timer.js'

export default class Main extends Component {
  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.welcome}>Pomodoro Timer</Text>
        <Timer />
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'tomato',
    marginTop: 60
  },
  welcome: {
    color: 'white',
    fontSize: 30,
    textAlign: 'center',
    margin: 50
  }
});

AppRegistry.registerComponent('Main', () => Main)
