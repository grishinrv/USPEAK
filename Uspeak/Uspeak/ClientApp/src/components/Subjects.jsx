import React, { Component } from 'react';
import flexStyle from '../styles/flex.module.css';
import {createUseStyles} from 'react-jss'

const flagStyle = createUseStyles({
  eng: {
    background: {
      color: '#00247d',
      size: '100%'
    },
    position: 'relative',
    '&:before': {
      position: 'absolute',
      content: '""',
      top: 0,
      left: 0,
      background: 'linear-gradient(180deg,transparent 40%, #cc142b 0,#cc142b 60%,transparent 0),\n' +
        '  linear-gradient(90deg,transparent 45%,#cc142b 0,#cc142b 55%,transparent 0),\n' +
        '  linear-gradient(180deg,transparent 35%,#fff 0,#fff 65%,transparent 0),\n' +
        '  linear-gradient(90deg,transparent 40%,#fff 0,#fff 60%,transparent 0),\n' +
        '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -65% 45%,\n' +
        '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 55% -45%,\n' +
        '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -75% -43%,\n' +
        '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 70% 46%,\n' +
        '  linear-gradient(146deg,transparent 45%,#fff 0,#fff 55%,transparent 0),\n' +
        '  linear-gradient(34deg,transparent 45%,#fff 0,#fff 55%,transparent 0)',
      width: '100%',
      height: '100%',
      'background-repeat': 'no-repeat'
    }
  },
  de: {
    width: '100%',
    height: '100%'
  }
});

const subjectRender = (subject) => {
  const classes = flagStyle();
  return (
    <div key={'key_'+subject.id} className={[flexStyle.flexItem, classes.eng].join(" ")}  />
  )
}

export class Subjects extends Component {
  static displayName = Subjects.name;

  static classes = flagStyle();
  constructor(props) {
    super(props);
    this.state = { subjects: [], loading: true };
  }

  componentDidMount() {
    this.getSubjects();
  }

  static mapFlag(cssClass) {
    return flagStyle.eng;
  }

  static renderSubjects(subjects) {
    const items = subjects.map(subject =>
      subjectRender(subject)
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
