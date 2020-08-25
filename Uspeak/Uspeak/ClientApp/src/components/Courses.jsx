import React, { useEffect, useState } from 'react';
import flexStyle from "../styles/flex.module.css";
import courseStyle from "../styles/courses.module.css";
import Course from "./Course";

export default function  Courses (props) {
  const [courses, setCourses] =  useState([]);
  const [loading, setLoading] =  useState(true);

  async function getCourses(subjectId) {
    const response = await fetch(`api/Courses/BySubject/${encodeURIComponent(subjectId)}`);
    const data = await response.json();
    setCourses(data);
    setLoading(false);
  }

  useEffect(() => {
    getCourses(props.match.params.subjectId);
  }, [props.match.params.subjectId]);

  function renderCourse(course) {
    return (<Course key={'key_'+course.id}  course={course} />);
  }

  function renderCourses(courses) {
    const items = courses.map(course =>
      renderCourse(course)
    );
    return (
      <div className={flexStyle.flexList}>
        {items}
      </div>
    );
  }

  let contents = loading
    ? <p><em>Loading...</em></p>
    : renderCourses(courses)
  return (
    <div className={courseStyle.courses}>
      <h1 style={{"textAlign": "center"}}>{props.name}</h1>
      {contents}
    </div>
  );
}