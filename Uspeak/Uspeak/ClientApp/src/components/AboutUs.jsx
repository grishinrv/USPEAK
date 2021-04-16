import React, {useEffect, useState} from 'react';

export default function AboutUs () {
  const [aboutUsFullText, setAboutUsFullText] =  useState('');
  const [loading, setLoading] =  useState(true);

  async function getAboutFullText() {
    const response = await fetch(`api/Info/AboutUsFullText`);
    const data = await response.text();
    setAboutUsFullText(data);
    setLoading(false);
  }

  useEffect(() => {
    getAboutFullText();
  });

  let contents = loading
    ? <p><em>Loading...</em></p>
    : <p>{aboutUsFullText}</p>
  return (<div>{contents}</div>)
}