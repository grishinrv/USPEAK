import React, { Component } from 'react';
import flexStyle from '../styles/flex.module.css';

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
    const items = subjects.map(subject =>
      <div key={'key_'+subject.id} className={[flexStyle.flexItem, subject.cssClass].join(" ")}  />
    );
    return (
      <div className={flexStyle.flexList}>
        {items}
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
    const response = await fetch('Tags/Subjects');
    const data = await response.json();
    this.setState({ subjects: data, loading: false });
  }
}
