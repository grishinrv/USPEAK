import React, { useEffect, useState } from 'react';
import flexStyle from "../styles/flex.module.css";

export default function  Courses (props) {
  const [courses, setCourses] =  useState([]);
  const [loading, setLoading] =  useState(true);

  async function getCourses(subjectId) {
    var url = new URL('Courses'),
        params = {'subjectId':subjectId.toString()};
    Object.keys(params).forEach(key => url.searchParams.append(key, params[key]))
    const response = await fetch(url);
    const data = await response.json();
    setCourses(data);
    setLoading(false);
  }

  useEffect(() => {
    getCourses(props.match.params.subjectId);
  }, []);

  let contents = loading
    ? <p><em>Loading...</em></p>
    : <div/>
  return (
    <div>
      <h1 style={{"textAlign": "center"}}>this.state.header</h1>
      {contents}
    </div>
  );
}