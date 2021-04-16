import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import Subjects  from './components/Subjects';
import { QuestionTemplate } from './components/QuestionTemplate';
import './custom.css'
import Courses from "./components/Courses";
import AboutUs from "./components/AboutUs";

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/subject-s' component={Subjects} />
        <Route path='/about-us' component={AboutUs} />
        <Route path='/question-template' component={QuestionTemplate} />
        <Route path='/courses/:subjectId' component={Courses}/>
      </Layout>
    );
  }
}
