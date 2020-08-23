import React from 'react';
import {createUseStyles} from 'react-jss';

export default function FlagStyle() {
  return createUseStyles({
    eng: {
      background: {
        color: '#00247d',
        size: '100%'
      },
      position: 'relative',
      '&:before': {
        position: 'absolute',
        content: '""',
        top: 0,
        left: 0,
        background: 'linear-gradient(180deg,transparent 40%, #cc142b 0,#cc142b 60%,transparent 0),\n' +
          '  linear-gradient(90deg,transparent 45%,#cc142b 0,#cc142b 55%,transparent 0),\n' +
          '  linear-gradient(180deg,transparent 35%,#fff 0,#fff 65%,transparent 0),\n' +
          '  linear-gradient(90deg,transparent 40%,#fff 0,#fff 60%,transparent 0),\n' +
          '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -65% 45%,\n' +
          '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 55% -45%,\n' +
          '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -75% -43%,\n' +
          '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 70% 46%,\n' +
          '  linear-gradient(146deg,transparent 45%,#fff 0,#fff 55%,transparent 0),\n' +
          '  linear-gradient(34deg,transparent 45%,#fff 0,#fff 55%,transparent 0)',
        width: '100%',
        height: '100%',
        'background-repeat': 'no-repeat'
      }
    },
    de: {
      background: {
        color: '',
        size: '100%'
      },
      position: 'relative',
      '&:before': {
        position: 'absolute',
        content: '""',
        top: 0,
        left: 0,
        background: 'linear-gradient(180deg,transparent 40%, #cc142b 0,#cc142b 60%,transparent 0),\n' +
          '  linear-gradient(90deg,transparent 45%,#cc142b 0,#cc142b 55%,transparent 0),\n' +
          '  linear-gradient(180deg,transparent 35%,#fff 0,#fff 65%,transparent 0),\n' +
          '  linear-gradient(90deg,transparent 40%,#fff 0,#fff 60%,transparent 0),\n' +
          '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -65% 45%,\n' +
          '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 55% -45%,\n' +
          '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -75% -43%,\n' +
          '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 70% 46%,\n' +
          '  linear-gradient(146deg,transparent 45%,#fff 0,#fff 55%,transparent 0),\n' +
          '  linear-gradient(34deg,transparent 45%,#fff 0,#fff 55%,transparent 0)',
        width: '100%',
        height: '100%',
        'background-repeat': 'no-repeat'
      }
    },
  });
}