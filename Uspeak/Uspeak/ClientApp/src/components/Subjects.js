import React, { Component } from 'react';
import '../styles/Common.css';

export class Subjects extends Component {
  static displayName = Subjects.name;

  constructor(props) {
    super(props);
    this.state = { subjects: [], loading: true };
  }

  componentDidMount() {
    this.getSubjects();
  }

  static renderSubjects(subjects) {
    return (
      <div className="flexlist">
        <div className="flexitem eng"/>
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
      : Subjects.renderSubjects(this.state.subjects);
    return (
      <div>
        <h1 style={{"textAlign": "center"}}>Направления обучения</h1>
        {contents}
      </div>
    );
  }

  async getSubjects() {
  //  let response = await fetch('/api/Tags/GetSubjects');
  //  const data = await response.json();
  //  this.setState({ subjects: data, loading: false });
    fetch('Tags')
      .then(function(response) {                      // first then()
          return response.text();
      })
      .then(function(text) {                          // second then()
        console.log(text);
      })
      .catch(function(error) {                        // catch
        console.log('Request failed', error);
      });
  }
}
