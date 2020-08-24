import React  from 'react';
import tagStyle from '../styles/tag.module.css';

export default function Tag (props) {
  return (
    <div className={tagStyle.tag}>
      {props.tag.name}
    </div>
  );
}