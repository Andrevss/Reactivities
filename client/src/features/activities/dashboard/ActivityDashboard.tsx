import ActivityDetails from '../details/ActivityDetails';
import ActivityList from './ActivityList'
import { Grid } from '@mui/material';


type Props = {
  activities: Activity[]
}

export default function ActivityDashboard({ activities }: Props) {
  return (
    <Grid container spacing={3}>
      <Grid size={7}>
        <ActivityList activities={activities} />
      </Grid>
      <Grid size={5}>
        {activities[0] && <ActivityDetails activity={activities[0]} />}
      </Grid>
    </Grid>
  )
}
