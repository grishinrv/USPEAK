import React, { Component } from 'react';
import '../styles/Common.css';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);
    this.state = { subjects: null, loading: true };
  }

  componentDidMount() {
    this.getSubjects();
  }

  static renderSubjects(subjects) {
    return (
      <div class="flexlist">
        <div class="flexitem"/>
        <div class="flexitem"/>
        <div class="flexitem"/>
        <div class="flexitem"/>
        <div class="flexitem"/>
        <div class="flexitem"/>
      </div>
    );
  }

  render () {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Home.renderSubjects(this.state.subjects);
    return (
      <div>
        <h1 style={{"text-align": "center"}}>Направления обучения</h1>
        {contents}
      </div>
    );
  }

  async getSubjects() {
    const response = await fetch('Tags/GetSubjects');
    const data = await response.json();
    this.setState({ subjects: data, loading: false });
  }
}
