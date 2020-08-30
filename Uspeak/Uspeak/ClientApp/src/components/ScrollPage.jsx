import React from 'react';
import {createUseStyles} from 'react-jss';

const useStyles = createUseStyles({
  contentScroll: {
    'overflow-y': 'auto',
    'overflow-x': 'hidden',
    'height': '83vh',
    'width': '78.75vw'
  },

  '@media (orientation: landscape) and (max-width: 1080px)':{
    contentScroll: {
      width: '89.5vw'
    }
  },
  '@media (orientation: landscape ) and (max-height: 800px)':{
    contentScroll: {
      height: '65vh'
    }
  },
  '@media (orientation: portrait )': {
    contentScroll: {
      width: '95vw'
    }
  },

  withoutHeader: {
    '@media (orientation: portrait )': {
      contentScroll: {
        height: '80vh'
      }
    }
  },
  withHeader: {
    '@media (orientation: portrait )': {
      contentScroll: {
        height: '72vh'
      }
    }
  }
});

export default function ScrollPage (props) {
  const classes = useStyles();
  const template = props.header ?
    <div>
      <h2 style={{"textAlign": "center"}}>{props.header}</h2>
      <div className={[classes.contentScroll,
        '@media (orientation: landscape) and (max-width: 1080px)',
        '@media (orientation: landscape ) and (max-height: 800px)',
        '@media (orientation: portrait )',
        classes.withHeader].join(" ")}>
        {props.children}
      </div>
    </div>
    :
    <div>
      <div className={[classes.contentScroll, classes.withoutHeader].join(" ")}>
        {props.children}
      </div>
    </div>;
  return (template);
}