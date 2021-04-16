import React from 'react';
import {createUseStyles} from 'react-jss';
import { useMediaQuery } from 'react-responsive';

const useStyles = createUseStyles({
    contentScroll: {
      'overflow-y': 'auto',
      'overflow-x': 'hidden'
    },
    defaultHeight: {
      height: '73vh'
    },
    defaultWidth: {
      width: '78.75vw'
    },
    landscapeMaxWidthLow: {
      width: '79.5vw',
    },
    landscapeMaxHeightLow: {
      height: '65vh'
    },
    withoutHeaderPortrait: {
      height: '80vh'
    },
    withHeaderPortrait: {
      height: '72vh'
    }
  });

export default function ScrollPage (props) {
  const classes = useStyles();
  let template;

  const isLandScape = useMediaQuery({ query: '(orientation: landscape)'});
  const isPortrait = useMediaQuery({ query: '(orientation: portrait)'});
  const isLowHeight = useMediaQuery({ query: '(max-height: 800px)'});
  const isLowWidth = useMediaQuery({ query: '(max-width: 1080px)'});

  if (props.header)
  {
    if (isPortrait)
    {
      template =
        <div>
          <h2 style={{"textAlign": "center"}}>{props.header}</h2>
          <div className={[classes.contentScroll, classes.defaultHeight, classes.withHeaderPortrait].join(" ")}>
            {props.children}
          </div>
        </div>
    }
    else if(isLandScape && isLowHeight)
    {
      template =
        <div>
          <h2 style={{"textAlign": "center"}}>{props.header}</h2>
          <div className={[classes.contentScroll, classes.landscapeMaxHeightLow, classes.defaultWidth].join(" ")}>
            {props.children}
          </div>
        </div>
    }
    else if(isLandScape && isLowWidth)
    {
      template =
        <div>
          <h2 style={{"textAlign": "center"}}>{props.header}</h2>
          <div className={[classes.contentScroll, classes.landscapeMaxWidthLow, classes.defaultHeight].join(" ")}>
            {props.children}
          </div>
        </div>
    }
    else
    {
      template =
        <div>
          <h2 style={{"textAlign": "center"}}>{props.header}</h2>
          <div className={[classes.contentScroll, classes.defaultHeight, classes.defaultWidth].join(" ")}>
            {props.children}
          </div>
        </div>
    }
  }
  else
  {
    if (isPortrait)
    {
      template =
        <div>
          <div className={[classes.contentScroll, classes.defaultHeight, classes.withoutHeaderPortrait].join(" ")}>
            {props.children}
          </div>
        </div>
    }
    else if(isLandScape && isLowHeight)
    {
      template =
        <div>
          <div className={[classes.contentScroll, classes.landscapeMaxHeightLow, classes.defaultWidth].join(" ")}>
            {props.children}
          </div>
        </div>
    }
    else if(isLandScape && isLowWidth)
    {
      template =
        <div>
          <div className={[classes.contentScroll, classes.landscapeMaxWidthLow, classes.defaultHeight].join(" ")}>
            {props.children}
          </div>
        </div>
    }
    else
    {
      template =
        <div>
          <div className={[classes.contentScroll, classes.defaultHeight, classes.defaultWidth].join(" ")}>
            {props.children}
          </div>
        </div>
    }
  }

  return (template);
}