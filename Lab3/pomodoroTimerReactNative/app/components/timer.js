import React, { Component } from 'react';
import { AppRegistry, StyleSheet, Text, Button, View } from 'react-native';

let TimerMixin = require('react-timer-mixin');

let timerDuration = 25 * 60; // total time in seconds
let initialTime = '25:00'; // initial timer display
let timerInterval;
let startTime;
let timeLeft;
let minutes;
let seconds;

const styles = StyleSheet.create({
  container: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  button: {
    backgroundColor: 'white',
    color: 'tomato',
    fontSize: 40,
    padding: 10,
    textAlign: 'center'
  },
  timer: {
    color: 'white',
    fontSize: 75,
    textAlign: 'center',
    margin: 10
}
});


let Timer = React.createClass({
  mixins: [TimerMixin],

  getInitialState: function() {
    return {
      timeRemaining: initialTime,
      isStarted: false
    }
  },

  render() {
		return (
      <View style={styles.container}>
        <Button
          style={styles.button}
          onPress={this.handleClick}
          title={ this.state.isStarted ? "stop timer" : "start timer" }>
        </Button>
        <Text style={styles.timer}>{this.state.timeRemaining}</Text>
      </View>
    );
	},

  handleClick(event) {
    if (this.state.isStarted) {
      this.stopCountdown();
    } else {
      this.startCountdown();
    }
  },

  timer() {
    timeLeft = timerDuration - (((Date.now() - startTime)/1000) | 0 );

    minutes = (timeLeft / 60) | 0;
    seconds = (timeLeft % 60) | 0;

    minutes = minutes < 10 ? '0' + minutes : minutes;
    seconds = seconds < 10 ? '0' + seconds : seconds;

    if ( timeLeft > -1 ) {
      this.setState({
        timeRemaining: minutes + ':' + seconds
      });
    } else {
      this.stopCountdown();
    }
  },

  startCountdown() {
    startTime = Date.now();
    this.timer();
    timerInterval = this.setInterval(this.timer, 1000);
    this.setState({
      isStarted: true
    });
  },

  stopCountdown() {
    this.clearInterval(timerInterval);
    this.setState({
      timeRemaining: initialTime,
      isStarted: false
    });
  }
});


export default Timer;
