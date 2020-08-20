import React, { Component } from 'react';
import '../styles/Common.css';
import {Subjects} from "./Subjects";

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <Subjects/>
      </div>
    );
  }

}
