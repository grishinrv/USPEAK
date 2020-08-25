import React, {useEffect, useState} from 'react';
import flexStyle from '../styles/flex.module.css';
import courseStyle from '../styles/course.module.css';
import Tag from "./Tag";

export default function Course (props) {
  const [tags, setTags] =  useState([]);
  const [loading, setLoading] =  useState(true);

  async function getTags(courseId) {
    const response = await fetch(`api/Tags/ByEntity/${encodeURIComponent(courseId)}`);
    const data = await response.json();
    setTags(data);
    setLoading(false);
  }

  useEffect(() => {
    getTags(props.course.id);
  }, [props.course.id]);

  function renderTag(tag) {
    return (<Tag key={'key_'+tag.id}  tag={tag} />);
  }

  function renderTags(tags) {
    const items = tags.map(tag =>
      renderTag(tag));
    return (
      <div className={flexStyle.flexList}>
        {items}
      </div>
    );
  }

  let contents = loading
    ? <p><em>Loading...</em></p>
    : renderTags(tags)
  return (
    <div className={[flexStyle.flexItemDefaultWidth, courseStyle.course].join(" ")}>
      <h2 style={{"textAlign": "center"}}>{props.course.name}</h2>
      {contents}
      <p>{props.course.description}</p>
    </div>
  );
}