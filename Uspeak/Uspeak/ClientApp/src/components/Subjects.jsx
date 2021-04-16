import React, { useEffect, useState } from 'react';
import flexStyle from '../styles/flex.module.css';
import textStyle from '../styles/text.css'; //шрифты заголовков
import Flag from "./Flag";
import {Link} from "react-router-dom";
import ScrollPage from "./ScrollPage";

export default function Subjects(){
  const [subjects, setSubjects] =  useState([]);
  const [subjectsLoading, setSubjectsLoading] =  useState(true);
  const [aboutUsShortText, setAboutUsShortText] =  useState('');
  const [aboutUsShortTextLoading, setAboutUsShortTextLoading] =  useState(true);

  async function getSubjects() {
    const response = await fetch('api/Tags/Subjects');
    const data = await response.json();
    setSubjects(data);
    setSubjectsLoading(false);
  }
  async function getAboutShortText(courseId) {
    const response = await fetch(`api/Info/AboutUsShortText`);
    const data = await response.text();
    setAboutUsShortText(data);
    setAboutUsShortTextLoading(false);
  }

  useEffect(() => {
    getAboutShortText();
  });

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

  let contents = subjectsLoading
    ? <p><em>Loading...</em></p>
    : renderSubjects(subjects);

  let aboutUsText = aboutUsShortTextLoading
    ? <p><em>Loading...</em></p>
    : <p><em>{aboutUsShortText}</em></p>
  return (
    <ScrollPage header='Направления обучения'>
      {aboutUsText}
      {contents}
    </ScrollPage>
  );
}
