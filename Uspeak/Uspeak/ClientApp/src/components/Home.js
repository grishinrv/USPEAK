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
      <div className="flexlist">
        <div className="flexitem">
          <div className="eng"/>
        </div>
        <div className="flexitem eng"/>
        <div className="flexitem"/>
        <div className="flexitem"/>
        <div className="flexitem"/>
        <div className="flexitem"/>
        <div className="flexitem"/>
        <div className="flexitem"/>
      </div>
    );
  }

  render () {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Home.renderSubjects(this.state.subjects);
    return (
      <div>
        <h1 style={{"textAlign": "center"}}>Направления обучения</h1>
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
