import React  from 'react';
import tagStyle from '../styles/tag.module.css';
import custom from '../custom.css';

export default function Tag (props) {
  return (
    <div className={[tagStyle.tag, custom.shadowBox].join(" ")}>
      {props.tag.name}
    </div>
  );
}