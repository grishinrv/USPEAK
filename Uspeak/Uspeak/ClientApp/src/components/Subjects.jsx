import React, { useEffect, useState } from 'react';
import flexStyle from '../styles/flex.module.css';
import textStyle from '../styles/text.css'; //шрифты заголовков
import Flag from "./Flag";
import {Link} from "react-router-dom";

export default function Subjects(){
  const [subjects, setSubjects] =  useState([]);
  const [loading, setLoading] =  useState(true);

  async function getSubjects() {
    const response = await fetch('api/Tags/Subjects');
    const data = await response.json();
    setSubjects(data);
    setLoading(false);
  }

  useEffect(() => {
    getSubjects();
  }, []);

  function renderSubject(subject) {
      return (
        <div key={'key_'+subject.id} className={flexStyle.flexItem} >
          <Link to={`/courses/${subject.id}`} name={subject.name}>
            <Flag cssClass={subject.cssClass}>
              <div className={[flexStyle.flagContent]}>
                <h3>{subject.name}</h3>
              </div>
            </Flag>
          </Link>
        </div>
      );
  }

  function renderSubjects(subjects) {
    const items = subjects.map(subject =>
      renderSubject(subject)
    );
    return (
      <div className={flexStyle.flexList}>
        {items}
      </div>
    );
  }

  let contents = loading
    ? <p><em>Loading...</em></p>
    : renderSubjects(subjects);
  return (
    <div className={flexStyle.contentScroll}>
      <h2 className={textStyle.textCenter}>Направления обучения</h2>
      {contents}
    </div>
  );
}
