import React from 'react';
import flexStyle from '../styles/flex.module.css';

export default function Course (props) {
  return (
    <div className={flexStyle.flexItemFullWidth}>
      <h2 style={{"textAlign": "center"}}>{props.course.name}</h2>
      <p>{props.course.description}</p>
    </div>
  );
}