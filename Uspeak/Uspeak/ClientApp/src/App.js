import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { QuestionTemplate } from './components/QuestionTemplate';

import './custom.css'
import {Subjects} from "./components/Subjects";

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/Tags/GetSubjects' component={Subjects} />
        <Route path='/QuestionTemplate' component={QuestionTemplate} />
      </Layout>
    );
  }
}
