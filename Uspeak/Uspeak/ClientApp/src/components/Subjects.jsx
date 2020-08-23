import React, { useEffect, useState } from 'react';
import flexStyle from '../styles/flex.module.css';
import text from '../styles/text.css'; //шрифты заголовков
import FlagStyle from "./FlagStyle";

export default function Subjects(){
  const classes = FlagStyle();
  const [subjects, setSubjects] =  useState([]);
  const [loading, setLoading] =  useState(true);

  async function getSubjects() {
    const response = await fetch('Tags/Subjects');
    const data = await response.json();
    setSubjects(data);
    setLoading(false);
  }

  useEffect(() => {
    getSubjects();
  }, []);

  function renderSubject(subject, classes) {
    return (
      <div key={'key_'+subject.id} className={[flexStyle.flexItem, flexStyle.it].join(" ")}  >
        <div className={[flexStyle.flagContent]}>
          <h2>{subject.name}</h2>
        </div>
      </div>
    )
  }

  function renderSubjects(subjects, classes) {
    const items = subjects.map(subject =>
      renderSubject(subject, classes)
    );
    return (
      <div className={flexStyle.flexList}>
        {items}
      </div>
    );
  }

  let contents = loading
    ? <p><em>Loading...</em></p>
    : renderSubjects(subjects, classes);
  return (
    <div>
      <h1 style={{"textAlign": "center"}}>Направления обучения</h1>
      {contents}
    </div>
  );
}
